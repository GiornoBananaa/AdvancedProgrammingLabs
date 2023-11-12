namespace Kirillov_Abstraction;
// Задание 2
/*
 2. Создайте систему для управления библиотекой книг. 
Создайте абстрактный класс "Книга" с абстрактным методом "Получить информацию". 
Создайте производные классы "Художественная книга" и "Научная книга", 
которые реализуют этот метод с различными логиками получения информации.
Создайте коллекцию объектов этих классов и выведите информацию о каждой книге.
*/


abstract class Book
{
    protected int Pages;
    protected string Author;
    
    public Book(int pages, string author)
    {
        Pages = pages;
        Author = author;
    } 
        
    public abstract string GetInformation();
}

class FictionBook : Book
{
    public FictionBook(int pages, string author) : base(pages, author) { }
    
    public override string GetInformation()
    {
        return $"'Автор этого художественного произведения - {Author}. Размер книги состовляет {Pages}";
    }
}

class ScientificBook : Book
{
    private string _scientificTheme;

    public ScientificBook(int pages, string author, string scientificTheme) : base(pages, author)
    {
        _scientificTheme = scientificTheme;
    }

    public override string GetInformation()
    {
        return $"Автор этой научной книги - {Author}. Её основная тема - {_scientificTheme}. Размер книги состовляет {Pages}";
    }
 }