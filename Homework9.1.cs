namespace Homework9._1;
class Program
{
    static void Main(string[] args)
    {
        Customer alice = new Customer(cus_id:110,cus_name:"Alice",cus_age:28);
        Customer bob = new Customer(cus_id:111,cus_name: "Bob",cus_age:30);
        alice.PrintCusInfo();
        bob.PrintCusInfo;
        alice.CompareAge(bob);
        bob.CompareAge(alice);
        alice.ChangeID(220);
        bob.ChangeID(221);
        
    }
}


class Customer{
    private int cus_id;
    public int cus_age {get;set;} = 0;
    public string cus_name  {get;set;}= string.Empty;
    public Customer(int cus_age, string cus_name){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }

 
    public void CompareAge(Customer objCust){
        Console.WriteLine($"Current name is: {cus_age}");
        if(this.cus_age <= objCust.cus_age){
            Console.WriteLine($"{objCust.cus_name} is older");
        }else{
            Console.WriteLine($"{this.cus_name} is older");
        }
    }
    public void ChangeID(int new_id){
        cus_id = new_id; 
    }
    public void PrintCusInfo(){
        Console.WriteLine("Customer ID: {cus_id}");
        Console.WriteLine("Customer Name: {cus_name}");
        Console.WriteLine("Customer Age: {cus_age}");
    }
}
