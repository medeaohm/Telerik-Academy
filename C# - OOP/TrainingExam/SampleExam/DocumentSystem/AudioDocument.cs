namespace DocumentSystem
{
    using System.Collections.Generic;

    public class AudioDocument : MutimediaDocument
    {
        public int? SampleRateHz { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "samplerate")
            {
                this.SampleRateHz = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRateHz));
        }
    }
}
