Console.WriteLine("Введите  колчиество слов которое хотите вписать");
int n =Convert.ToInt32(Console.ReadLine());
string [] inarray = new string [n];
Fillarray();
void Fillarray(){
for (int i =0; i< inarray.Length;i++){
    inarray[i] = Console.ReadLine();
}
}