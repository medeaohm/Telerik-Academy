function solve() {
    return function (selector, isCaseSensitive) {
        var sentitive = false || isCaseSensitive;

        var selectorToUse; 
        if (isCaseSensitive) {
            selectorToUse = selector;
        }
        else {
            selectorToUse = selector.toLowerCase();
        }

        var root = document.getElementById('root');
        var element = document.querySelector(selector);


        var add = document.createElement('div');
        var label = document.createElement("Label");
        var input = document.createElement("Input");
        var bnt = document.createElement("Button");
        label.innerHTML = 'Enter Text';
        bnt.innerHTML ='Add';
        bnt.className = 'button';
        add.className = 'add-controls';
        add.appendChild(label);
        add.appendChild(input);
        add.appendChild(bnt);
        element.appendChild(add);

        var search = document.createElement('div');
        search.className = 'search-controls';
        var labelS = document.createElement("Label");
        labelS.innerHTML = 'Search';
        var inputS = document.createElement("Input");
        search.appendChild(labelS);
        search.appendChild(inputS);
        element.appendChild(search);

        var result = document.createElement('div');
        result.className = 'result-controls';
        var list = document.createElement('div');
        list.className = 'items-list';
        result.appendChild(list);
        element.appendChild(result);

        inputS.addEventListener('input', function (ev) {
            var text = ev.target.value;
            for (var i = 0; i < document.getElementsByClassName('list-item').length; i++) {
                var currentListItem = document.getElementsByClassName('list-item')[i];
                var where = currentListItem.innerHTML;
                if (!sentitive) {
                    text = text.toLowerCase();
                    where = where.toLowerCase();
                }
                if (where.indexOf(text) < 0) {
                    currentListItem.style.display = 'none';
                }
                else {
                    currentListItem.style.display = 'block';
                }
                
            }
        }, false);

        bnt.addEventListener('click', function () {
            var listItem = document.createElement('div');
            listItem.className = 'list-item';
            var itemBtn = document.createElement('Button');
            itemBtn.className = 'button';     
            itemBtn.innerHTML = 'X';
            var itemText = document.createElement('div');
            //itemText.className = 'text';
            listItem.innerHTML = input.value;
            listItem.appendChild(itemBtn);
            //listItem.appendChild(itemText);
            list.appendChild(listItem);

            itemBtn.addEventListener('click', function (ev) {
                var target = ev.target;
                var toDelete = target.parentNode;
                toDelete.parentNode.removeChild(toDelete);
            });


        });
        
        return this;
  };
}

module.exports = solve;