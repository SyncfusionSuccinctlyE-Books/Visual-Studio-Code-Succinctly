public interface IDocument
{
    void LoadDocument();
    void SaveDocument();
    string DocumentName { get;set;}
    string DocumentPath {get;set;}
}

