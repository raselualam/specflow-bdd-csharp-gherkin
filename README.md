# specflow-bdd-csharp-gherkin
Today i am focus to setup a Visual Studio Project for SpecFlow with C# and guide you to Develop and Run SpecFlow test by simple 10 Steps. Its easy more then you thinking.

# What is SpecFlow?
Use SpecFlow to define, manage and automatically execute human-readable acceptance tests in .NET projects. Writing easily understandable tests is a cornerstone of the BDD paradigm and also helps build up a living documentation of your system.

SpecFlow is open source and provided under a BSD license. As part of the Cucumber family, SpecFlow uses the official Gherkin parser and supports the .NET framework, Xamarin and Mono.

SpecFlow integrates with Visual Studio, but can be also used from the command line (e.g. on a build server). SpecFlow supports popular testing frameworks: MSTest, NUnit (2 and 3), xUnit 2 and MbUnit.

SpecFlow+ adds additional functionality to SpecFlow, such as Visual Studio Test Explorer integration, a dedicated test runner with advanced test execution options, execution reports (HTML, XML, JSON) and much more.

# Get Started Now !

Step 1 : Create a Unit Test project in Visual Studio.

Step 2 : Add NuGet Packages References of “SpecFlow” and “SpecRun”.

Step 3: Add Tools Extensions of “SpecFlow for Visual Studio”.

Step 4: Add feature file by adding new items.

Step 5: Write feature file using ‘Given’, ‘And’, ‘When’, ‘Then’ etc. You may describe ‘Feature’ and ‘Scenario’ also using ‘@’ add tags.

Step 6: Generating Step Definition. To generate step definition right click on scenario and click on ‘Generate Step Definition’.

Step 7: Select Steps which one you want to Generate Step Definition for, rename your Steps class and click Generate. Saving the ‘Steps Class’ inside same project location is a good practice.

Step 8: Write your selenium or other code in ‘Step Class’ to execute that particular step. You will see Step definition method created for your each steps of feature files. If you don’t complete your all step definition method with your selenium or other code for a particular scenario the test may get failed, so write your code before continue.

Step 9.1: Make sure your App.config has and plugins has . Take a look to below ‘App.config’ screenshot to make sure your config file setup is correct.

Step 9.2: You may also run your test using MsTest/NUnit. In that case put ‘Mstest’ or ‘Nunit’ as unit test provider. For now i am running my test using MsTest, so adding and commenting out ‘SpecRun’.

Step 10: Build the solution and Run test. You may run your test from ‘Test Explorer’ or right clicking on feature file and clicking ‘Run SpecFlow Scenarios.
