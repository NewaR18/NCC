using System;
using System.Threading.Tasks; 
using System.Net.Http; 
namespace Examples
{
    class AsyncProgram{ 
        public async Task<string> GetUrlContentLengthAsync(string url) 
        { 
            Console.WriteLine($"Connecting to {url}and fetching the contents.."); 
            var client = new HttpClient(); 
            Task<string> getStringTask = client.GetStringAsync(url); 
            DoIndependentWork(); 
            string contents = await getStringTask; 
            Console.WriteLine("Fetching completed !"); 
            return contents; 
        } 
        void DoIndependentWork(){ 
            Console.WriteLine("Working.."); 
            Console.WriteLine("Completed."); 
        } 
        static void Main(string[] args){ 
            AsyncProgram ap = new AsyncProgram(); 
            Task<string> result = ap.GetUrlContentLengthAsync("https://www.nytimes.com/games/wordle/index.html"); 
            Console.WriteLine("Elements inside html tag is presented below: ");
            for(int i=0; i < result.Result.Length; i++)
            {
                if (result.Result[i] == '>')
                {
                    Console.Write(result.Result[i] + "\n");
                }
                else
                {
                    Console.Write(result.Result[i]);
                }
                if (result.Result[i] == '>' && result.Result[i-1] == 'd' && result.Result[i-2] == 'a' && result.Result[i-3] == 'e' && result.Result[i-4] == 'h' && result.Result[i-5] == '/' && result.Result[i-6] == '<')
                {
                    break;
                }
            }
            Console.WriteLine("\n\n--------------------------");
            Console.WriteLine("Lab no: 18");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        } 
    } 
}