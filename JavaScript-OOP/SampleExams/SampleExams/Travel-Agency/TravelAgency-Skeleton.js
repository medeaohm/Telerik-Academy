function processTravelAgencyCommands(commands) {
    'use strict';

    var parseDate = function (dateStr) {
        if (!dateStr) {
            return undefined;
        }
        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }
        return date;
    }

    var formatDate = function (date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();
        return day + '-' + monthName + '-' + year;
    }

    var extendClass = function (child, parent) {
        child.prototype = Object.create(parent.prototype);
        child.prototype.constructor = child;
    }

    var Validators = {
        validateNonEmptyString: function (value, variableName) {
            if (typeof (value) != 'string' || !value) {
                throw new Error(variableName + " should be a non-empty string. Invalid value: " + value);
            }
        },

        validateNonNegativeNumber: function (value, variableName) {
            if (isNaN(value) || value < 0) {
                throw new Error(variableName + 'should be a positive number: ' + value);
            }
        },

        validateDate: function (date, variableName) {
            if (typeof (date) != 'object' || !(date instanceof Date)) {
                throw new Error(variableName + " should be a Date object. Invalid value: " + date);
            }
            if (isNaN(date.getTime())) {
                throw new Error(variableName + " should be a valid date. Invalid value: " + date);
            }
        },

        isNullOrUndefined: function (value) {
            return (typeof (value) == 'undefined') || (value == null);
        }

    }

    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    }

    var Models = (function () {

        var Destination = (function() {
            function Destination(location, landmark) {
                this.setLocation(location);
                this.setLandmark(landmark);
            }

            Destination.prototype.getLocation = function() {
                return this._location;
            }

            Destination.prototype.setLocation = function(location) {
                if (location === undefined || location === "") {
                    throw new Error("Location cannot be empty or undefined.");
                }
                this._location = location;
            }

            Destination.prototype.getLandmark = function() {
                return this._landmark;
            }

            Destination.prototype.setLandmark = function(landmark) {
                if (landmark === undefined || landmark == "") {
                    throw new Error("Landmark cannot be empty or undefined.");
                }
                this._landmark = landmark;
            }

            Destination.prototype.toString = function() {
                return this.constructor.name + ": " +
                    "location=" + this.getLocation() +
                    ",landmark=" + this.getLandmark();
            }

            return Destination;
        }());

        // Travels hold name, start date, end date and price
        var Travel = (function () {

            function Travel(name, startDate, endDate, price) {
                if (this.constructor === Travel) {
                    throw new Error('Cannot instantiate abstract class Travel.');
                }

                this.setName(name);
                this.setStartDate(startDate);
                this.setEndDate(endDate);
                this.setPrice(price);
            }

            //Travel name should be a non-empty string
            Travel.prototype.getName = function () {
                return this._name;
            }
            Travel.prototype.setName = function (name) {
                Validators.validateNonEmptyString(name, "name");
                this._name = name;
            }

            //Travel start date should be a valid Date object
            Travel.prototype.getStartDate = function () {
                return this._startDate;
            }
            Travel.prototype.setStartDate = function (startDate) {
                Validators.validateDate(startDate, "startDate");
                this._startDate = startDate;
            }

            //Travel end date should be a valid Date object
            Travel.prototype.getEndDate = function () {
                return this._endDate;
            }
            Travel.prototype.setEndDate = function (endDate) {
                Validators.validateDate(endDate, "endDate");
                this._endDate = endDate;
            }

            //Travel price should always be a non-negative number 
            Travel.prototype.getPrice = function () {
                return this._price;
            }
            Travel.prototype.setPrice = function (price) {
                Validators.validateNonNegativeNumber(price, 'price');
                this._price = price;
            }

            Travel.prototype.getTravelInfo = function () {
                return " * " + this.constructor.name + ": " +
                    "name=" + this.getName() +
                    ",start-date=" + formatDate(this.getStartDate()) +
                    ",end-date=" + formatDate(this.getEndDate()) +
                    ",price=" + this.getPrice().toFixed(2);
            }

            Travel.prototype.toString = function () {
                return this.getTravelInfo();
            }

            return Travel;
        }());

        // Excursions are travels with a set of destinations and a means of transport - holds a set of destinations and transport, holds addDestination() and removeDestination() methods – throws an error if it contains no such destination
        var Excursion = (function () {

            extendClass(Excursion, Travel);

            function Excursion(name, starDate, endDate, price, transports) {
                Travel.apply(this, arguments);
                this.setTransports(transports);
                this._destinations = [];
            }

            Excursion.prototype.getDestinations = function () {
                return this._destinations;
            }

            Excursion.prototype.addDestination = function (destination) {
                this.getDestinations().push(destination);
            }

            Excursion.prototype.removeDestination = function (destination) {
                var index = this.getDestinations().indexOf(destination);
                if (index !== -1) {
                    this.getDestinations().splice(index, 1);
                }
                else {
                    throw new Error("Travel does not contain such destination.");
                }
            }

            // Excursion transport should be a non-empty string
            Excursion.prototype.getTransports = function () {
                return this._transports;
            }
            Excursion.prototype.setTransports = function (transports) {
                Validators.validateNonEmptyString(transports, 'transports');
                this._transports = transports;
            }

            Excursion.prototype.getDestinationsInfo = function () {
                var destinationsInfo;
                destinationsInfo = " ** Destinations: " +
                    (this.getDestinations().length > 0 ? this.getDestinations().join(";") : "-");

                return destinationsInfo;
            }

            Excursion.prototype.toString = function () {
                return Travel.prototype.getTravelInfo.call(this) +
                    ",transport=" + this.getTransports() + "\n" + this.getDestinationsInfo();
            }

            return Excursion;
        }());

        // Vacations are travels with a location and accommodation
        var Vacation = (function () {

            extendClass(Vacation, Travel);

            function Vacation(name, startDate, endDate, price, location, accommodation) {
                Travel.apply(this,arguments);
                this.setLocation(location);
                this.setAccommodation(accommodation);
            }

            //	Vacation location should be a non-empty string
            Vacation.prototype.getLocation = function () {
                return this._location;
            }
            Vacation.prototype.setLocation = function (location) {
                Validators.validateNonEmptyString(location, 'location');
                this._location = location;
            }

            //	Vacation accommodation is optional and should be a non-empty string when it exists
            Vacation.prototype.getAccommodation = function () {
                return this._accommodation;
            }
            Vacation.prototype.setAccommodation = function (accommodation) {
                if (!Validators.isNullOrUndefined(accommodation)) {
                    Validators.validateNonEmptyString(accommodation, "accommodation");
                    this._accommodation = accommodation;
                }
                else {
                    delete this._accommodation;
                }
            }

            Vacation.prototype.toString = function () {
                var accommodationText = this.getAccommodation() ? ",accommodation=" + this.getAccommodation() : '';
                return Travel.prototype.toString.call(this) +
                    ',location=' + this.getLocation() + accommodationText;
            }

            return Vacation;
        }());

        // Cruises are excursions with a starting dock – holds start dock, transport is always "cruise liner"
        var Cruise = (function () {
            
            var CRUISE_TRANSPORT = 'cruise liner';

            extendClass(Cruise, Excursion);

            function Cruise(name, startDate, endDate, price, transports, startDock) {
                Excursion.call(this, name, startDate, endDate, price, CRUISE_TRANSPORT, startDock);
                this.setStartDock(startDock);
            }

            // Cruise starting dock is optional and should be a non-empty string when it exists
            Cruise.prototype.getStartDock = function () {
                return this._startDock;
            }
            Cruise.prototype.setStartDock = function (startDock) {
                if (! Validators.isNullOrUndefined (startDock)) {
                    Validators.validateNonEmptyString(startDock, 'startDock');
                    this._startDock = startDock;
                }
                else {
                    delete this._startDock;
                }
            }

            Cruise.prototype.toString = function () {
                return Excursion.prototype.toString.call(this) +
                    (this.getStartDock() ? ",start-dock=" + this.getStartDock() : "");
            }

            return Cruise;
        }());

        return {
            Destination: Destination,
            Travel: Travel,
            Excursion: Excursion,
            Vacation: Vacation,
            Cruise: Cruise
        }
    }());

    var TravellingManager = (function(){
        var _travels;
        var _destinations;

        function init() {
            _travels = [];
            _destinations = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "excursion":
                        object = new Models.Excursion(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["transport"]);
                        _travels.push(object);
                        break;
                    case "vacation":
                        object = new Models.Vacation(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["location"], command["accommodation"]);
                        _travels.push(object);
                        break;
                    case "cruise":
                        object = new Models.Cruise(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["start-dock"]);
                        _travels.push(object);
                        break;
                    case "destination":
                        object = new Models.Destination(command["location"], command["landmark"]);
                        _destinations.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }

                return object.constructor.name + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index,
                    destinations;

                switch (command["type"]) {
                    case "destination":
                        object = getDestinationByLocationAndLandmark(command["location"], command["landmark"]);
                        _travels.forEach(function(t) {
                            if (t instanceof Models.Excursion && t.getDestinations().indexOf(object) !== -1) {
                                t.removeDestination(object);
                            }
                        });
                        index = _destinations.indexOf(object);
                        _destinations.splice(index, 1);
                        break;
                    case "excursion":
                    case "vacation":
                    case "cruise":
                        object = getTravelByName(command["name"]);
                        index = _travels.indexOf(object);
                        _travels.splice(index, 1);
                        break;
                    default:
                        throw new Error("Unknown type.");
                }

                return object.constructor.name + " deleted.";
            }

            function processListCommand(command) {
                return formatTravelsQuery(_travels);
            }

            // filter – filters all travels by type (unless specified "all") and in a specified price range (inclusive). Returns the travels sorted by their start date in ascending order, then by name (always unique) as secondary criteria. 
            function processFilterInPriceRange(command) {
                var type = command["type"],
                    priceMin = parseFloat(command["price-min"]),
                    priceMax = parseFloat(command["price-max"]),
                    filteredByType,
                    filteredByPrice,
                    sortedByDateAsc;

                filteredByType = _travels
                    .filter(function (e) {
                        switch (type) {
                            case "excursion":
                                return e.constructor.name === "Excursion";
                            case "vacation":
                                return e.constructor.name === "Vacation";
                            case "cruise":
                                return e.constructor.name === "Cruise";
                            case "all":
                                return true;
                            default:
                                return false;
                        }
                    });

                filteredByPrice = filteredByType
                    .filter(function(e){
                        return priceMin <= e.getPrice() && e.getPrice() <= priceMax;
                    });

                sortedByDateAsc = filteredByPrice
                    .sort(function (e1, e2) {
                        var dateOne = e1.getStartDate().valueOf(),
                            dateTwo = e2.getStartDate().valueOf();

                        if (dateOne === dateTwo) {
                            return e1.getName().localeCompare(e2.getName());
                        }
                        return dateOne - dateTwo;
                    });

                return formatTravelsQuery(sortedByDateAsc);
            }

            function processAddDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.addDestination(destination);

                return "Added destination to " + travel.getName() + ".";
            }

            function processRemoveDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.removeDestination(destination);

                return "Removed destination from " + travel.getName() + ".";
            }

            function getTravelByName(name) {
                var i;

                for (i = 0; i < _travels.length; i++) {
                    if (_travels[i].getName() === name) {
                        return _travels[i];
                    }
                }
                throw new Error("No travel with such name exists.");
            }

            function getDestinationByLocationAndLandmark(location, landmark) {
                var i;

                for (i = 0; i < _destinations.length; i++) {
                    if (_destinations[i].getLocation() === location
                        && _destinations[i].getLandmark() === landmark) {
                        return _destinations[i];
                    }
                }
                throw new Error("No destination with such location and landmark exists.");
            }

            function formatTravelsQuery(travelsQuery) {
                var queryString = "";

                if (travelsQuery.length > 0) {
                    queryString += travelsQuery.join("\n");
                } else {
                    queryString = "No results.";
                }

                return queryString;
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processFilterTravelsCommand: processFilterInPriceRange,
                processAddDestinationCommand: processAddDestinationCommand,
                processRemoveDestinationCommand: processRemoveDestinationCommand
            }
        }());

        var Command = (function() {
            function Command(cmdLine) {
                this._cmdArgs = processCommand(cmdLine);
            }

            function processCommand(cmdLine) {
                var parameters = [],
                    matches = [],
                    pattern = /(.+?)=(.+?)[;)]/g,
                    key,
                    value,
                    split;

                split = cmdLine.split("(");
                parameters["command"] = split[0];
                while ((matches = pattern.exec(split[1])) !== null) {
                    key = matches[1];
                    value = matches[2];
                    parameters[key] = value;
                }

                return parameters;
            }

            return Command;
        }());

        function executeCommands(cmds) {
            var commandArgs = new Command(cmds)._cmdArgs,
                action = commandArgs["command"],
                output;

            switch (action) {
                case "insert":
                    output = CommandProcessor.processInsertCommand(commandArgs);
                    break;
                case "delete":
                    output = CommandProcessor.processDeleteCommand(commandArgs);
                    break;
                case "add-destination":
                    output = CommandProcessor.processAddDestinationCommand(commandArgs);
                    break;
                case "remove-destination":
                    output = CommandProcessor.processRemoveDestinationCommand(commandArgs);
                    break;
                case "list":
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case "filter":
                    output = CommandProcessor.processFilterTravelsCommand(commandArgs);
                    break;
                default:
                    throw new Error("Unsupported command.");
            }

            return output;
        }

        return {
            init: init,
            executeCommands: executeCommands
        }
    }());

    var output = "";
    TravellingManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != "") {
            try {
                result = TravellingManager.executeCommands(cmd) + "\n";
            } catch (e) {
                result = "Invalid command." + "\n";
            }
            output += result;
        }
    });

    return output;
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processTravelAgencyCommands(arr));
        });
    }
})();