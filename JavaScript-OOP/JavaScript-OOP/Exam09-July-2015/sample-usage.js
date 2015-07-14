function solve() {
    function indexOfElementWithIdInCollection(collection, id) {
        var i, len;
        for (i = 0, len = collection.length; i < len; i++) {
            if (collection[i].id == id) {
                return i;
            }
        }

        return -1;
    }

    function getSortingFunction(firstParameter, secondParameter) {
        return function (first, second) {
            if (first[firstParameter] < second[firstParameter]) {
                return -1;
            }
            else if (first[firstParameter] > second[firstParameter]) {
                return 1;
            }

            if (first[secondParameter] < second[secondParameter]) {
                return -1;
            }
            else if (first[secondParameter] > second[secondParameter]) {
                return 1;
            }
            else {
                return 0;
            }
        }
    }

    validator = {
        
        validateNonEmptyString: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val != 'string') {
                throw new Error(name + ' must be a string: ' + val);
            }
        },

        validateString: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }

            if (val.length < 2 || 40 < val.length) {
                throw new Error(name + ' must be between ' + 2 +
                    ' and ' + '40' + ' symbols');
            }
        },

        validateGenre: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }

            if (val.length < 2 || 20 < val.length) {
                throw new Error(name + ' must be between ' + '2' +
                    ' and ' + '20' + ' symbols');
            }
        },

        validateISBN: function (val){
            if (!(/^[0-9]{10}/.test(val)) && !(/^[0-9]{13}/.test(val)) ) {
                throw new Error();
            }
        },

        validatePositiveNumber: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfNumber(val, name);

            if (val <= 0) {
                throw new Error(name + ' must be positive number');
            }
        },

        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined');
            }
        },

        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'number') {
                throw new Error(name + ' must be a number');
            }
        },

    };


    Item = (function () {
        var currentItemId = 0,
            Item = Object.create({});

        Object.defineProperty(Item, 'init', {
            value: function (description, name) {
                this.description = description;
                this.name = name;
                this._id = ++currentItemId;
                return this;
            }
        });

        Object.defineProperty(Item, 'id', {
            get: function () {
                return this._id;
            }
        });

        Object.defineProperty(Item, 'description', {
            get: function () {
                return this._description;
            },
            set: function (val) {
                validator.validateNonEmptyString(val, 'Item Description');
                this._description = val;
            }
        });

        Object.defineProperty(Item, 'name', {
            get: function () {
                return this._name;
            },
            set: function (val) {
                validator.validateString(val, 'Item Name');
                this._name = val;
            }
        });

        return Item;
    }());

    Book = (function (parent) {
        var Book = Object.create(parent);

        Object.defineProperty(Book, 'init', {
            value: function (name, isbn, genre, description) {
                parent.init.call(this, description, name);
                this.isbn = isbn;
                this.genre = genre;
                return this;
            }
        });

        Object.defineProperty(Book, 'isbn', {
            get: function () {
                return this._isbn;
            },
            set: function (val) {
                validator.validateNonEmptyString(val, 'isbn');
                validator.validateISBN(val);
                this._isbn = val;
            }
        });

        Object.defineProperty(Book, 'genre', {
            get: function () {
                return this._genre;
            },
            set: function (val) {
                validator.validateGenre(val, 'genre');
                this._genre = val;
            }
        });


        return Book;
    }(Item));

    Media = (function (parent) {
        var Media = Object.create(parent);

        Object.defineProperty(Media, 'init', {
            value: function (name, isbn, genre, description) {
                parent.init.call(this, description, name);
                this.duration = duration;
                this.rating = rating;
                return this;
            }
        });

        Object.defineProperty(Media, 'duration', {
            get: function () {
                return this._duration;
            },
            set: function (val) {
                validator.validatePositiveNumber(val, 'duration');
                this._duration = val;
            }
        });

        Object.defineProperty(Media, 'rating', {
            get: function () {
                return this._rating;
            },
            set: function (val) {
                validator.validateIfNumber(val, 'rating');
                if (rating < 1 || rating > 5) {
                    throw new Error();
                }
                this._rating = val;
            }
        });


        return Media;
    }(Item));

    Catalog = (function () {

        var currentCatalogId = 0,
            Catalog = Object.create({});

        Object.defineProperty(Catalog, 'init', {
            value: function (name) {                
                this._id = ++currentCatalogId;
                this._items = [];
                this.name = name;
                return this;
            }
        });

        Object.defineProperty(Catalog, 'id', {
            get: function () {
                return this._id;
            }
        });


        Object.defineProperty(Catalog, 'name', {
            get: function () {
                return this._name;
            },
            set: function (val) {
                validator.validateString(val, 'Catalogue Name');
                this._name = val;
            }
        });


        Object.defineProperty(Catalog, 'add', {
            value: function (ItemsToAdd) {
                var itemsToBeAdded = ItemsToAdd.split(',');
                for (var i = 0; i < itemsToBeAdded.length; i++) {
                    validator.validateIfUndefined(Item, 'Catalog add item parameter');
                    validator.validateIfObject(Item, 'Catalog add item parameter');
                    validator.validateIfUndefined(Item.id, 'Catalog add item parameter must have id');
                    this._items.push(itemsToBeAdded[i]);
                }
                
                return this;
            }
        });



        //Object.defineProperty(Catalog, 'add', {
        //    value: function (item) {
        //        if (item === 'undefined'  || !(item instanceof Item)) {
        //            throw new Error();
        //        }
        //        this.items.push(item);
        //        return this;
        //    }
        //}),


        Object.defineProperty(Catalog, 'find', {
            value: function (id) {
                var i, len;
                validator.validateIfUndefined(id, 'Playlist get playable parameter id');
                validator.validateIfNumber(id, 'Playlist get playable paratemeter id');

                var foundIndex = indexOfElementWithIdInCollection(this._items, id);
                if (foundIndex < 0) {
                    return null;
                }

                return this._items[foundIndex];
            }
        });

        Object.defineProperty(Catalog, 'listItems', {
            value: function () {
               return this._items;
            }
        });

        Object.defineProperty(Catalog, 'search', {
            value: function (pattern) {
                validator.validateNonEmptyString(pattern, 'Search pattern');
                if (pattern.length < 1) {
                    throw new Error();
                }

                return this._items
                    .filter(function (items) {
                        return Item
                            .listItems()
                            .some(function (Item) {
                                return Item.length !== undefined
                                    && Item
                                        .name
                                        .toLowerCase()
                                        .indexOf(pattern.toLowerCase()) >= 0
                                    || Item
                                            .description
                                            .toLowerCase()
                                            .indexOf(pattern.toLowerCase()) >= 0;
                            });
                    })
                    .map(function (Item) {
                        return Item;
                    });
            }
        })

        Object.defineProperty(Catalog, 'findById', {
            value: function (id) {
                
                var foundIndex = indexOfElementWithIdInCollection(this._items, id);
                if (foundIndex < 0) {
                    return null;
                }
                return this._items[foundIndex];;
            }
        });

        return Catalog;
    }());

    BookCatalog = (function (parent) {
        var  BookCatalog = Object.create(parent);

        Object.defineProperty(BookCatalog, 'init', {
            value: function (name) {
                parent.init.call(this, name);
                return this;
            }
        });

        Object.defineProperty(BookCatalog, 'add', {
            value: function (BooksToAdd) {
                parent.init.call(this, BooksToAdd);
                return this;
            }
        });
        /*
         *     *   getGenres()
        *   **Returns an array of lowercase strings**
            *   All the unique genres of books that are added
         */

        Object.defineProperty(BookCatalog, 'getGenres', {
            value: function () {
                var allGenres = [];
                for (var i = 0; i < this._items.length; i++) {
                    this.allGenres.push(this._items[i].genre.toLowerCase());
                }
                return allGenres;
            }
        });

        return BookCatalog;
    }(Catalog));

    MediaCatalog = (function (parent) {
        var MediaCatalog = Object.create(parent);

        Object.defineProperty(MediaCatalog, 'init', {
            value: function (name) {
                parent.init.call(this, name);
                return this;
            }
        });

        Object.defineProperty(MediaCatalog, 'add', {
            value: function (MediaToAdd) {
                parent.init.call(this, MediaToAdd);
                return this;
            }
        });

        Object.defineProperty(MediaCatalog, 'getTop', {
            value: function (count) {
                validator.validateIfNumber(count, 'count');
                if (count < 1) {
                    throw new Error();
                }

                return this._items
                    .slice()
                    .sort(getSortingFunction('rating'))
                    .splice(count)
                .map(function (items) {
                    return {
                        id: Media.id,
                        name: Media.name,
                    }
                });
            }
        });

        Object.defineProperty(MediaCatalog, 'getSortedByDuration', {
            value: function () {

                return this._items
                    .slice()
                    .sort(getSortingFunction('duration', 'id'))
                    .splice()
            }
        });

        return MediaCatalog;
    }(Catalog));

    return {

		getBook: function (name, isbn, genre, description) {
		    return Object.create(Book).init(name, isbn, genre, description);
		},
		getMedia: function (name, rating, duration, description) {
		    return Object.create(Media).init(name, isbn, genre, description);
		},
		getBookCatalog: function (name) {
		    return Object.create(BookCatalog).init(name);
		},
		getMediaCatalog: function (name) {
		    return Object.create(MediaCatalog).init(name);
		}
	};
}

var module = solve();
var cname = 'John catalog';
var catalog = module.getBookCatalog(cname);

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1, book2);
catalog.add(book2);

console.log(catalog.listItems());
console.log(catalog.find(book1.id));
//returns book1

//console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

//console.log(catalog.search('js')); 
// returns book2

//console.log(catalog.search('javascript'));
//returns book1 and book2

//console.log(catalog.search('Te sa zeleni'))
//returns []
