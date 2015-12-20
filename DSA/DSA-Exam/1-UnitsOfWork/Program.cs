namespace UnitsOfWork
{
    // inspiration here : https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Exam/2014/Problem%203%20-%20Data%20Structures%20(Doncho)/Solution

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Unit : IComparable<Unit>
    {
        public string Name
        {
            get; set;
        }

        public int Attack
        {
            get; set;
        }

        public string Type
        {
            get; set;
        }

        public override string ToString()
        {
            return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack); 
        }

        public override bool Equals(object obj)
        {
            var other = obj as Unit;

            if (other == null)
            {
                return false;
            }

            return this.Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return 23 + this.Name.GetHashCode() >> 17 ^
                   (23 + this.Attack.GetHashCode() >> 17 ^
                    (23 + this.Type.GetHashCode() >> 17));
        }

        public int CompareTo(Unit other)
        {
            var attackCompareResult = -(this.Attack.CompareTo(other.Attack));

            if (attackCompareResult == 0)
            {
                var nameCompareResult = this.Name.CompareTo(other.Name);

                if (nameCompareResult == 0)
                {
                    return this.Type.CompareTo(other.Type);
                }
                else
                {
                    return nameCompareResult;
                }
            }
            else
            {
                return attackCompareResult;
            }
        }

        public static Unit ParseUnit(string unitString)
        {
            var productParts = unitString.Split(' ');
            var name = productParts[0];            
            var type = productParts[1];
            var attack = int.Parse(productParts[2]);

            return new Unit()
            {
                Name = name,
                Attack = attack,
                Type = type
            };
        }
    }

    public enum CommandType
    {
        End,
        Add,
        Remove,
        Find,
        Power 
    }

    public class Command
    {
        public string Params
        {
            get; set;
        }

        public static Dictionary<string, CommandType> stringToCommandType;

        static Command()
        {
            stringToCommandType = new Dictionary<string, CommandType>();
            stringToCommandType["add"] = CommandType.Add;
            stringToCommandType["end"] = CommandType.End;
            stringToCommandType["find"] = CommandType.Find;
            stringToCommandType["remove"] = CommandType.Remove;
            stringToCommandType["power"] = CommandType.Power;
        }

        public CommandType Type
        {
            get; set;
        }

        public static Command ParseCommand(string input)
        {
            foreach (var pair in stringToCommandType)
            {
                if (input.StartsWith(pair.Key))
                {
                    return new Command()
                    {
                        Type = pair.Value,
                        Params = input.Substring(pair.Key.Length).Trim()
                    };
                }
            }

            return null;
        }
    }

    public class UnitsFactory
    {
        HashSet<Unit> units;
        SortedSet<Unit> byPower;
        Dictionary<string, SortedSet<Unit>> byType;
        Dictionary<string, Unit> byName;


        public UnitsFactory()
        {
            this.units = new HashSet<Unit>();
            this.byPower = new SortedSet<Unit>();
            this.byType = new Dictionary<string, SortedSet<Unit>>();
            this.byName = new Dictionary<string, Unit>();
        }

        public bool AddUnit(Unit unit)
        {
            if (this.units.Contains(unit))
            {
                return false;
            }

            if (!(this.byType.ContainsKey(unit.Type)))
            {
                this.byType[unit.Type] = new SortedSet<Unit>();
            }

            this.units.Add(unit);
            this.byPower.Add(unit);
            this.byType[unit.Type].Add(unit);
            this.byName[unit.Name] = unit;

            return true;
        }

        public bool RemoveUnit(string name)
        {
            if (!this.byName.ContainsKey(name))
            {
                return false;
            }
            var unitToRemove = this.byName[name];

            this.units.Remove(unitToRemove);
            this.byPower.Remove(unitToRemove);
            this.byType[unitToRemove.Type].Remove(unitToRemove);
            this.byName.Remove(name);

            return true;
        }

        public IEnumerable<Unit> FilterPowerUnits(int numberOfUnits)
        {         
            return this.byPower.Take(numberOfUnits).OrderByDescending(u => u.Attack).ThenBy(u => u.Name);
        }

        public IEnumerable<Unit> FilterUnits(string type)
        {
            if (!(byType.ContainsKey(type)))
            {
                return null;
            }
            return this.byType[type].Take(10).OrderByDescending(u => u.Attack).ThenBy(u => u.Name);
        }
    }

    class Program
    {
        public static void Main()
        {
            const string UnitAddedSuccessFormat = "SUCCESS: {0} added!";
            const string UnitAddedErrorFormat = "FAIL: {0} already exists!";
            const string UnitRemoveSuccessFormat = "SUCCESS: {0} removed!";
            const string UnitRemoveErrorFormat = "FAIL: {0} could not be found!";
            const string FilterSuccessFormat = "RESULT: {0}";
            const string InvalidTypeErrorFormat = "Error: Type {0} does not exists";


            var unitsFactory = new UnitsFactory();

            while (true)
            {
                string input = Console.ReadLine();
                var command = Command.ParseCommand(input);
                switch (command.Type)
                {
                    case CommandType.End:
                        return;
                    case CommandType.Add:
                        var unit = Unit.ParseUnit(command.Params);
                        var addResult = unitsFactory.AddUnit(unit);
                        string format;
                        if (addResult)
                        {
                            format = UnitAddedSuccessFormat;
                        }
                        else
                        {
                            format = UnitAddedErrorFormat;
                        }
                        Console.WriteLine(format, unit.Name);
                        break;
                    case CommandType.Remove:
                        string unitToRemoveName = command.Params.Split(' ')[0];
                        var removeResult = unitsFactory.RemoveUnit(unitToRemoveName);
                        string formatToRemove;
                        if (removeResult)
                        {
                            formatToRemove = UnitRemoveSuccessFormat;
                        }
                        else
                        {
                            formatToRemove = UnitRemoveErrorFormat;
                        }
                        Console.WriteLine(formatToRemove, unitToRemoveName);
                        break;
                    case CommandType.Power:
                        int number = int.Parse(command.Params.Split(' ')[0]);
                        var result = unitsFactory.FilterPowerUnits(number);
                        Console.WriteLine(FilterSuccessFormat, string.Join(", ", result));
                        break;
                    case CommandType.Find:
                        var findByName = unitsFactory.FilterUnits(command.Params);
                        if (findByName == null)
                        {
                            Console.WriteLine("RESULT:");
                        }
                        else
                        {
                            Console.WriteLine(FilterSuccessFormat, string.Join(", ", findByName));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
