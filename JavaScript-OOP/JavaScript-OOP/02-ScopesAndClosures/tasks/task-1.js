/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
	    var books = [];
	    var categories = [];

		function listBooks(currentBook) {
		    if (arguments.length > 0) {
		        if (typeof currentBook.category !== 'undefined') {
		            if (typeof categories[currentBook.category] !== 'undefined') {
		                return categories[currentBook.category].books;
		            } else {
		                return [];
		            }
		        }
		        if (typeof currentBook.author !== 'undefined') {
		            var booksInList = [];
		            for (var i = 0; i < books.length; i++) {
		                if (books[i].author === currentBook.author) {
		                    booksInList.push(books[i]);
		                }
		            }
		            return booksInList;
		        }
		    }
		    return books;
		}


		function alreadyExist(name, type) {
		    for (var i = 0; i < books.length; i++) {
		        if (books[i][type] === name) {
		            return true;
		        }
		    }
		    return false;
		}

		function createCategory(name) {
		    categories[name] = {
		        books: [],
		        ID: categories.length + 1
		    };
		}

		function checkBookInfo(book, argumentLenght) {
		    if (Object.keys(book).length !== argumentLenght) {
		        throw new Error('Book parameters missing');
		    }
		    for (var parameter in book) {
		        if (typeof book[parameter] === 'undefined') {
		            throw new Error(parameter + ' is undefined');
		        }
		    }
		}

		function validAuthor(author) {
		    if (author.trim() === '') {
		        throw new Error('Author name cannot be empty');
		    }
		}

		function validISBN(isbn) {
		    if (isbn.length !== 10 && isbn.length !== 13) {
		        throw new Error('ISBN must coinatin either 10 or 13 digits');
		    }
		    if (!/^[0-9]+$/.test(isbn.toString())) {
		        throw new Error('ISBN must contains only numbers');
		    }
		}

		function validationLenght(name) {
		    if (name.length < 2 || name.length > 100) {
		        throw new Error('Field should be more than 2 and less than 100 symbols');
		    }
		}

		function addBook(book) {
		    book.ID = books.length + 1;

		    checkBookInfo(book, 5);

		    if (alreadyExist(book.title, 'title')) {
		        throw new Error('A book with the same title already exists.');
		    }
		    if (alreadyExist(book.isbn, 'isbn')) {
		        throw new Error('A book with the same ISBN already exists.');
		    }
		    if (categories.indexOf(book.category) < 0) {
		        createCategory(book.category);
		    }

		    validAuthor(book.author);
		    validISBN(book.isbn);
		    validationLenght(book.title);
		    validationLenght(book.category);

		    categories[book.category].books.push(book);

		    books.push(book);
		    return book;
		}


		function listCategories(category) {
		    var categoriesName = [];

		    Array.prototype.push.apply(categoriesName, Object.keys(categories));

		    return categoriesName;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
