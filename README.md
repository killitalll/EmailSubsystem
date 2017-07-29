# EmailSubsystem

## About The Demo App:

The basic function of this app is to automatically send an email to a specific recipient from the specified sender. It is implemented using the asp.net MVC framework and uses the Mailer.Net Nugget package.

## How it works:

**Package Installation:**

Install the Mailer.Net package.

**ConfigSection:**

 This set of code is added to the web.config file in the MVC application. it is added directly under <configuration>.

```
<configSections>
    <section name="mailernet" type="Mailer.NET.Mailer.Internal.ConfigFile.MailerNetSection, Mailer.NET, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" requirePermission="false" />
  </configSections>
```
**Mailer Configuration:**

This is the code in the web.config file that configures the mailer to use smtp.

```
<mailernet>
    <defaultTransport type="Mailer.NET.Mailer.Transport.SmtpTransport, Mailer.NET">
      <parameters>
        <parameter value="smtp.gmail.com"/>
        <parameter value="587" type="System.Int32"/>
        <parameter value="emailsubsystemtest@gmail.com"/>
        <parameter value="testtest1234"/>
        <parameter value="true" type="System.Boolean"/>
      </parameters>
    </defaultTransport>
  </mailernet> 
```

**Class Setup:**

There is a Mailer class that implements this code that allows it to send a given message to a specified user. Currently it is not using the singleton pattern.

```
Email email = new Email(EmailContentType.Html)
{
From = new Contact() { Name = "Alex", Email = "emailsubsystemtest@gmail.com" }
};
email.AddTo("alexradevitunes@gmail.com", "Alex");
email.Subject = "Video is sent";
//email.Template = "template";
email.Message = "Hello World";
//email.AddTemplateVar("person", "teste");
//email.AddTemplateVar("number", "123");
email.Send();
```

**Controller Setup:**

The code in the mailer class is executed from this controller using this simple code.

```
Models.Mailer mail = new Models.Mailer();
mail.sendEmail();
return View();
```

**Extras:**

When we implement further down the line we will be adding custom templates for the different emails that will be send out. The Mailer.Net package does support this feature.
































