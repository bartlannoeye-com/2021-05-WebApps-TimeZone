# Use a specific timezone in Azure App Service.
Azure services, including App Service, run in UTC by default. If your software uses local time for any reason (storing dates, parsing csv files, ...) then you'll curse after migrating your workload to the cloud. There's the option to start messing around with timezones in code to keep everything working, but you're also able to explicitly tell Azure App Service to operate in a specific time zone.

Clone this repository to have a quick deployable project to test if your Azure App Service is handling time as desired.

Blog post: https://bartlannoeye.com/blog/timezone-for-azure-appservice/