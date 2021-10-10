# Use a specific timezone in Azure App Service.
Azure services, including App Service, run in UTC by default. If your software uses local time for any reason (storing dates, parsing csv files, ...) then you'll curse after migrating your workload to the cloud. There's the option to start messing around with timezones in code to keep everything working, but you're also able to explicitly tell Azure App Service to operate in a specific time zone.

Clone this repository to have a quick deployable project to test if your Azure App Service is handling time as desired.

More info in this [blog post](https://bartlannoeye.com/blog/timezone-for-azure-appservice/).

You can use this to deploy the Windows app service plan in your own subscription:

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fbartlannoeye-com%2F2021-05-WebApps-TimeZone%2Fmain%2Fsrc%2FTimezone%2FProperties%2FServiceDependencies%2Ftimezonemvppoc%2520-%2520Web%2520Deploy%2Fprofile.arm.json)

You can use this to deploy the Linux app service plan in your own subscription:

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fbartlannoeye-com%2F2021-05-WebApps-TimeZone%2Fmain%2Fsrc%2FTimezone%2FProperties%2FServiceDependencies%2Ftimezonepocmvp%2520-%2520Web%2520Deploy%2Fprofile.arm.json)