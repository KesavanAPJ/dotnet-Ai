using System.Text.Json;

var http = new HttpClient();

Console.Write("Ask a question: ");
string question = Console.ReadLine();

string url = "http://localhost:8000/ask?question=" + Uri.EscapeDataString(question);

string json = await http.GetStringAsync(url);

string answer = JsonDocument.Parse(json).RootElement.GetProperty("answer").GetString();

Console.WriteLine("AI says: " + answer);