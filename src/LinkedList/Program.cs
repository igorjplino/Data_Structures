
var linkedList = new LinkedList.LinkedList<int>();

linkedList.Append(1);
linkedList.Append(2);
linkedList.Append(3);
linkedList.Append(4);
linkedList.Append(5);

Console.WriteLine("LinkedList values: {0}", linkedList.ToString());

var index = linkedList.GetIndex(3);
Console.WriteLine("Index of the value '3': {0}", index);

//var value = linkedList.GetNodeByIndex(4);

//Console.WriteLine("Value of the index '4': {0}", value.Data);

linkedList.Insert(6, 9);
Console.WriteLine("LinkedList values: {0}", linkedList.ToString());

index = linkedList.GetIndex(9);
Console.WriteLine("Index of the value '9': {0}", index);

var tt = new List<int>();
