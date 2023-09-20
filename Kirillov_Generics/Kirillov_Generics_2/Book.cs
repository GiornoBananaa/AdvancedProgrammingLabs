namespace Kirillov_Generics_2;

public class Book<T>
{
    private string _name;
    private int _pagesCount;
    private string _author;
    private T _id;

    public Book(string name, int pagesCount, string author, T id)
    {
        _name = name;
        _pagesCount = pagesCount;
        _author = author;
        _id = id;
    }

    public override string ToString()
    {
        return $"{_id} {_name}, {_author}, {_pagesCount} страниц";
    }
}