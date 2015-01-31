# Guestbook Project

### Requirements

 * Visual Studio 2013
 * MS SQL Server 2008 +

Change Web.config connection string

``` 
...
<connectionStrings>
    <add name="Guestbook" connectionString="Data Source=.\SQLEXPRESS; Initial Catalog=GuestbookData; ...
</connectionStrings>
...
```