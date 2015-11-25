This is a simple page object webdriver test project. (Exclusive for william Hill Test .)

Feature implemented : 

1) cover chrome browser and firefox browser. (could have IE , other browser etc)
2) cover page object design 
3) place a single bet and assert the number of bet on Bet Slip

Environment : 
Win 7 
Visual Studio 2013
C#

Package installed : 

Selenium Webdriver  version 2.48.2
Selenium Webdriver support classes 2.48.2
System.Configuration.Abstractions 2.0.2.24
Nunit 2.6.4

<packages>
  <package id="NUnit" version="2.6.4" targetFramework="net45" />
  <package id="Selenium.Support" version="2.48.2" targetFramework="net45" />
  <package id="Selenium.WebDriver" version="2.48.2" targetFramework="net45" />
  <package id="System.Configuration.Abstractions" version="2.0.2.24" targetFramework="net45" />
</packages>

I didn't use Specflow due to time limition. 

Future development base on this project: 
1) logging
2) error report
3) integrate with Selenium Grid
4) BDD , such as Specflow 

