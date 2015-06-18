namespace DocumentSystem
{
    using System.Collections.Generic;

    public class ExcelDocument : OfficeDocument
    {
        public int? NumberOfRows { get; set; }
        public int? NumberOfColums { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.NumberOfRows = int.Parse(value);
            }
            if (key == "cols")
            {
                this.NumberOfColums = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfColums));
        }
    }
}
