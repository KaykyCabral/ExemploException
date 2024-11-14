try
{
    Conta c = new Conta();
    c.SetSAldo(-60);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}