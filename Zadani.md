Vytvorte

Třída Book: Atributy: Title, Author, ISBN, Year

Třídy Fiction, Nonfiction a Comic jako potomky třídy Book:
Třída Fiction bude mít navíc atribut Genre.
Třída Nonfiction bude mít navíc atribut Field.
Třída Comic bude mít navíc atribut Illustrator.

Třídu Library:
Atribut: List<Book> BookList
Metody:
AddBook(Book book): Přidá knihu do seznamu.
ShowBookList(): Vrátí textovou reprezentaci seznamu knih.
SaveToFile(string path): Uloží seznam knih do textového souboru.
