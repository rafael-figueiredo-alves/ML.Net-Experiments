using FirstMLExperiment;

Console.WriteLine("Welcome to my first ML.Net experiment\n");
Console.WriteLine("\n");
Console.WriteLine("Leave your opinion to be checked:\n");
string Opinion = Console.ReadLine();
Console.WriteLine("Ok, and the sentiment on this opinion is:\n");

var SampleData = new SentimentModel.ModelInput()
{
    Col0 = Opinion
};

var result = SentimentModel.Predict(SampleData);

var Sentiment = result.PredictedLabel == 1 ? "Your opinion was Positive" : "Your opinion was negative";

Console.WriteLine(Sentiment);


