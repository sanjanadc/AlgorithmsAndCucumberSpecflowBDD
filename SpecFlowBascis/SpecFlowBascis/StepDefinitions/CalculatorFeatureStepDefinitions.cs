using System;
using TechTalk.SpecFlow;
using TestClassLibrary;

namespace SpecFlowBascis.StepDefinitions
{
    [Binding]
    public class CalculatorFeatureStepDefinitions
    {
        // instantiating application instance 
        CalculatorApplication app = new CalculatorApplication();

        // variables to hold input values and the intermeditate result 
        int input1, input2;
        double output;

        [Given(@"I have provided (.*) and (.*) as the inputs")]
        public void GivenIHaveProvidedAndAsTheInputs(int p0, int p1)
        {
            input1 = p0;
            input2 = p1;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            output = app.add(input1, input2);
        }

        [Then(@"the result should be addition  (.*)")]
        public void ThenTheResultShouldBeAddition(int p0)
        {
            Assert.AreEqual(p0, output);
        }
        [Given(@"I have provided (.*) and (.*) as the inputs for subtraction")]
        public void GivenIHaveProvidedAndAsTheInputsForSubtraction(int p0, int p1)
        {
            input1 = p0;
            input2 = p1;
        }

        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            
            output = app.subsctract(input1, input2);
        }

        [Then(@"the result should be subtract (.*)")]
        public void ThenTheResultShouldBeSubtract(int p0)
        {
            Assert.AreEqual(p0, output);
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            output = app.multiply(input1, input2);
        }

        [Then(@"the result should be multiply (.*)")]
        public void ThenTheResultShouldBeMultiply(int p0)
        {
            Assert.AreEqual(p0, output);
        }

        [Given(@"I have provided (.*) and (.*) as the inputs for division")]
        public void GivenIHaveProvidedAndAsTheInputsForDivision(int p0, int p1)
        {
            input1 = p0;
            input2 = p1;
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            output = app.divide(input1, input2);
        }

        [Then(@"the result should be divide (.*)")]
        public void ThenTheResultShouldBeDivide(double p0)
        {
            Assert.AreEqual(p0, output);
        }

        [Given(@"I have provided (.*) as input for square root")]
        public void GivenIHaveProvidedAsInputForSquareRoot(int p0)
        {
            input1 = p0;
        }


        [When(@"I press squareroot")]
        public void WhenIPressSquareroot()
        {
            output = app.squareRoot(input1);
        }

        [Then(@"the result should be squareroot (.*)")]
        public void ThenTheResultShouldBeSquareroot(double p0)
        {
            Assert.AreEqual(p0,output);
        }
    }
}
