using System.Diagnostics;
using Newtonsoft.Json;
namespace CalculatorLibrary
{
    public class Calculator
    {
        public int usage = 0; 
        public List<string> History = new List<string>();
        
        JsonWriter writer;
        public Calculator() {

            History.Add("Calculator History\n");
            StreamWriter logFile = File.CreateText("calculator.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();

            //StreamWriter logFile = File.CreateText("calculator.log");
            //Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            //Trace.AutoFlush = true;
            //Trace.WriteLine("Starting calculator log");
            //Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        
        }
        public  double DoMath(double num1, double num2, string op)
        {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(num1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(num2);
            writer.WritePropertyName("Operation");

            switch (op.ToLower())
            {
                case "a":
                    result = num1 + num2;
                    writer.WriteValue("add");
                    History.Add($"{num1} + {num2} = {result}");
                    //Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
                    break;
                case "s":
                    result = num1 - num2;
                    writer.WriteValue("subtract");
                    History.Add($"{num1} - {num2} = {result}");
                    //Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));

                    break;
                case "m":
                    result = num1 * num2;
                    writer.WriteValue("multiply");
                    History.Add($"{num1} * {num2} = {result}");
                    //Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));

                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num2 / num1;
                        writer.WriteValue("divide");
                        History.Add($"{num1} / {num2} = {result}");
                        //Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));

                    }
                    break;
                default:
                    break;
            }
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();
            usage++;
           
            return result;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }

    }
}
