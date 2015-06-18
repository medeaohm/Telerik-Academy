namespace DocumentSystem
{
    using System.Collections.Generic;

    public class VideoDocument : MutimediaDocument
    {
        public int? FrameRateFps { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FrameRateFps = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRateFps));
        }
    }
}
