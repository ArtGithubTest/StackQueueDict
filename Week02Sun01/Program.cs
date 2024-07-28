namespace Classes
{


    class Program
    {


        public static void Main(string[] args)
        {
            //Queue -> First In First Out.
            Queue<string> stringQ = new Queue<string>();
            stringQ.Enqueue("Hi, ");
            stringQ.Enqueue("my ");
            stringQ.Enqueue("name ");
            stringQ.Enqueue("is ");
            stringQ.Enqueue("Artion.");
            //int frontItem = stringQ.Peek(); -> Vetem e SHIKON vleren e pare. Mund ta perdoresh brenda loopit While
            //ne menyre qe ti, nje here e ben Peek (e shef nqs e ka nje vlere te caktuar), pastaj ose vazhdon ta besh Dequeue
            //ose i ben Break loopit dhe te mbetet vlera te cilen po e kerkoje.
            //Contains(value) -> kthen true/false, Clear(pastron pjesen mbetur te Queues ose te gjithen, Peek (lexon pa hequr vleren e par)

            while (stringQ.Count > 0)
            {
                string item = stringQ.Dequeue();
                Console.WriteLine(item);
            }

            // Stack -> Last in, First out. Sikur patetinat Pringles, patetina e fundit e futur ne kanace, hahet e para.
            //Stack -> Push (fut), Pop (heq), Contains (a ka nej vler), Clear (pastron krej pjesen e mbetur te Stackut, ose te gjith)
            Stack<int> intS = new Stack<int>();
            intS.Push(1);
            intS.Push(2);
            intS.Push(3);
            intS.Push(4);

            while (intS.Count > 0)
            {
                int item = intS.Pop();
                Console.WriteLine(item); // output = 4,3,2,1
            }

            //Dictionary <key, value> -> Every key corresponds to a value. Key is the Index, value is the Value
            //<string, int>
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Orange", "It has vitamin C");
            dict.Add("Apple", "It has vitamin D");

            //access the things with Key
            string keyValue = dict["Apple"];
            Console.WriteLine($"Description for Apple: {keyValue}");

            if (dict.ContainsKey(keyValue)) //ContainsKey, ContainsValue
            { 
                //Do something
            }

            Dictionary<string, int> nameAge = new Dictionary<string, int>();
            nameAge.Add("Artion", 22);
            nameAge.Add("Kasandra", 24);
            nameAge.Add("Sokol", 15);
            nameAge.Add("Mira", 20);

            foreach (KeyValuePair<string, int> kvp in nameAge)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

        }
    }
}