namespace DocumentSystem
{
    using System.Collections.Generic;

    public class WorldDocument : OfficeDocument, IEditable
    {
        public int? NumberOfCharacters { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfCharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value); 
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("characters", this.NumberOfCharacters));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
