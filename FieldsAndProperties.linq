<Query Kind="Program" />

void Main()
{
     var result = new FooResponseDto();
     result.Dump();
     
     var bar = new BarResponseDto();
     bar.Status = "OK";
//   bar.status.Dump("status field");
//   bar.Status.Dump("Status property");
     
     result.Response = bar;
     result.Dump();
}

public class FooResponseDto 
{
     public FooResponseStatusDto ResponseStatus { get; set; }
     public BarResponseDto Response { get; set; }
}

public class FooResponseStatusDto  
{ 
     public int num;
}

public class BarResponseDto
{
     public string status;
     
     
     public string Status 
     { 
           get
           {
                return status;
           }
           set
           {
                status = value;
           }
     } 
}
