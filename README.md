#README

Needs the newest dotnet sdk
dotnet build
dotnet run

#The only issue
The plan was to use DateTime.Parse(string) in initializing the Publish date.
However we ended up with european time parsing vs. american problem so one Mac 
computer wanted different parsing for the string and a windows computer another. We
even tried the ParseExact function but had differrent issues then. All requirement are
still met under the services for ordering by the date we just needed to switch to 
DateTime.Now in initializing.


