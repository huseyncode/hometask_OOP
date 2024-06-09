namespace DocumentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            DocumentProgram basic = new DocumentProgram();
            basic.OpenDocument();
            basic.EditDocument();
            basic.SaveDocument();

            ProDocumentProgram pro = new ProDocumentProgram();
            pro.OpenDocument();
            pro.EditDocument();
            pro.SaveDocument();

            ExpertDocumentProgram expert = new ExpertDocumentProgram();
            expert.OpenDocument();
            expert.EditDocument();
            expert.SaveDocument();
        }
    }
}