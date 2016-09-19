/* globals document, window, console */

function solve() {
    return function(selector, initialSuggestions) {
        var mainDiv = document.querySelector(selector);
        var suggestionsList = mainDiv.getElementsByClassName('suggestions-list');

        for (var i = 0; i < initialSuggestions.length; i++) {
            var isThere = false;
            var currentInitialSuggestion = initialSuggestions[i];
            currentInitialSuggestion = currentInitialSuggestion.toLowerCase();
            var allSuggest = document.getElementsByClassName('suggestion-link');
            for (var j = 0; j < allSuggest.length; j++) {
                var text = allSuggest[j].innerText;
                text = text.toLowerCase();
                if (text === currentInitialSuggestion) {
                    isThere = true;
                    break;
                }
            }
            if (isThere === false) {
                var currentLi = document.createElement('li');
                currentLi.className = 'suggestion';
                suggestionsList[0].appendChild(currentLi);
                var currentA = document.createElement('a');
                currentA.href = '#';
                currentA.className = 'suggestion-link';
                currentA.addEventListener('click', clickAHref, false);
                currentLi.appendChild(currentA);
                currentA.innerText = initialSuggestions[i];
                // <li class="suggestion">
                // <a href="#" class="suggestion-link">Apple</a>
                // </li>
            }
        }
        var inputEl = mainDiv.getElementsByTagName('input');
        suggestionsList[0].style.display = 'none';
        inputEl[0].addEventListener('input', inputFunction, false);

        function inputFunction(params) {
            if (inputEl[0].value === '') {
                suggestionsList[0].style.display = 'none';
            } else {
                suggestionsList[0].style.display = '';
                var pattern = inputEl[0].value;
                pattern = pattern.toLowerCase();
                var onlyNameItemsList = document.getElementsByClassName('suggestion');
                var itemsList = document.getElementsByClassName('suggestion-link');
                for (var i = 0, len = itemsList.length; i < len; i += 1) {
                    text = itemsList[i].innerHTML;
                    text = text.toLowerCase();
                    if (text.indexOf(pattern) < 0) {
                        onlyNameItemsList[i].style.display = "none";
                    } else {
                        onlyNameItemsList[i].style.display = "";
                    }
                }
            }
        }
        var addElement = document.getElementsByClassName('btn-add');
        addElement[0].addEventListener('click', clickFunction, false);

        function clickFunction(params) {
            var isAlreadyThere = false;
            var pattern = inputEl[0].value;
            pattern = pattern.toLowerCase();
            // var onlyNameItemsList = document.getElementsByClassName('suggestion');
            var itemsList = document.getElementsByClassName('suggestion-link');
            for (var i = 0, len = itemsList.length; i < len; i += 1) {
                var currentPattern = itemsList[i].innerText;
                currentPattern = currentPattern.toLowerCase();
                if (currentPattern === pattern) {
                    isAlreadyThere = true;
                    break;
                }

            }
            if (isAlreadyThere === false) {
                var currentLi = document.createElement('li');
                currentLi.className = 'suggestion';
                suggestionsList[0].appendChild(currentLi);
                var currentA = document.createElement('a');
                currentA.href = '#';
                currentA.className = 'suggestion-link';
                currentA.addEventListener('click', clickAHref, false);
                currentLi.appendChild(currentA);
                currentA.innerText = inputEl[0].value;
            }
        }

        function clickAHref(params) {
            inputEl[0].value = this.innerText;
        }
    };
}