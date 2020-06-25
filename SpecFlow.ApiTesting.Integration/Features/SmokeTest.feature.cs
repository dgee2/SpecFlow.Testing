﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.ApiTesting.Integration.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SmokeTest")]
    public partial class SmokeTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SmokeTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SmokeTest", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I make a simple http method request")]
        [NUnit.Framework.TestCaseAttribute("GET", "https://jsonplaceholder.typicode.com/todos/1", null)]
        [NUnit.Framework.TestCaseAttribute("POST", "https://jsonplaceholder.typicode.com/todos/1", null)]
        [NUnit.Framework.TestCaseAttribute("PUT", "https://jsonplaceholder.typicode.com/todos/1", null)]
        [NUnit.Framework.TestCaseAttribute("PATCH", "https://jsonplaceholder.typicode.com/todos/1", null)]
        [NUnit.Framework.TestCaseAttribute("DELETE", "https://jsonplaceholder.typicode.com/todos/1", null)]
        public virtual void IMakeASimpleHttpMethodRequest(string method, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I make a simple http method request", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.When(string.Format("I make a {0} request to the {1} url", method, url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I make a simple http method request from config")]
        [NUnit.Framework.TestCaseAttribute("GET", null)]
        [NUnit.Framework.TestCaseAttribute("POST", null)]
        [NUnit.Framework.TestCaseAttribute("PUT", null)]
        [NUnit.Framework.TestCaseAttribute("PATCH", null)]
        [NUnit.Framework.TestCaseAttribute("DELETE", null)]
        public virtual void IMakeASimpleHttpMethodRequestFromConfig(string method, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I make a simple http method request from config", exampleTags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
testRunner.When(string.Format("I make a {0} request to the ApiUrl url from config", method), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request is valid Json")]
        public virtual void IValidateTheResponseOfAGETRequestIsValidJson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request is valid Json", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
testRunner.When("I make a GET request to the ApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.Then("The request response is valid Json", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains a specific key in the response")]
        public virtual void IValidateTheResponseOfAGETRequestContainsASpecificKeyInTheResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains a specific key in the response", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
testRunner.Then("the key $[1].title in the response exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains a specific count of elements")]
        public virtual void IValidateTheResponseOfAGETRequestContainsASpecificCountOfElements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains a specific count of elements", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
testRunner.Then("the key $ in the response contains 200 elements", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains the correct integer")]
        public virtual void IValidateTheResponseOfAGETRequestContainsTheCorrectInteger()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains the correct integer", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.Then("the key $[30].userId in the response equals the integer 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains an integer greater than")]
        public virtual void IValidateTheResponseOfAGETRequestContainsAnIntegerGreaterThan()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains an integer greater than", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.Then("the key $[30].userId in the response is greater than the integer 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains an integer greater than or equa" +
            "l to")]
        public virtual void IValidateTheResponseOfAGETRequestContainsAnIntegerGreaterThanOrEqualTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains an integer greater than or equa" +
                    "l to", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.Then("the key $[30].userId in the response is greater than or equal to the integer 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
testRunner.Then("the key $[30].userId in the response is greater than or equal to the integer 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains an integer less than")]
        public virtual void IValidateTheResponseOfAGETRequestContainsAnIntegerLessThan()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains an integer less than", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("the key $[30].userId in the response is less than the integer 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains an integer less than or equal t" +
            "o")]
        public virtual void IValidateTheResponseOfAGETRequestContainsAnIntegerLessThanOrEqualTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains an integer less than or equal t" +
                    "o", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
testRunner.Then("the key $[30].userId in the response is less than or equal to the integer 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
testRunner.Then("the key $[30].userId in the response is less than or equal to the integer 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I validate the response of a GET request contains the correct string")]
        public virtual void IValidateTheResponseOfAGETRequestContainsTheCorrectString()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I validate the response of a GET request contains the correct string", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
testRunner.When("I make a GET request to the TodosApiUrl url from config", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
testRunner.Then("the key $[105].title in the response equals the string ad illo quis voluptatem te" +
                    "mporibus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion