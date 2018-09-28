using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using TechnicalRadiation.Models.Exceptions;

namespace TechnicalRadiation.ExceptionHandlerExtensions
{
    public static class ExceptionHandlerExtensions
    {
        public static void GlobalExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if(exceptionHandlerFeature != null) 
                    {
                        var exception = exceptionHandlerFeature.Error;
                        //default statuscode
                        var statusCode = (int) HttpStatusCode.InternalServerError;

                        //Log the error in a database ????

                        if(exception is ArgumentOutOfRangeException)
                        {
                            statusCode = (int) HttpStatusCode.BadRequest;
                        }
                        else if(exception is ResourceNotFoundException)
                        {
                            statusCode = (int) HttpStatusCode.NotFound;
                        }
                        else if(exception is ModelFormatException)
                        {
                            statusCode = (int) HttpStatusCode.PreconditionFailed;
                        }
                        else if(exception is UnauthorizedException)
                        {
                            statusCode = (int) HttpStatusCode.Unauthorized;
                        }

                        /*ExceptionModel exceptionModel = new ExceptionModel{
                            StatusCode = statusCode,
                            Message = exception.Message,
                        };
                        */
                        //log ???
                        context.Response.ContentType = "application/json";
                        context.Response.StatusCode = statusCode;

                        await context.Response.WriteAsync(new ExceptionModel{
                            StatusCode = statusCode,
                            Message = exception.Message,
                        }.ToString());                        
                    }
                });
            });
        }
    }
}