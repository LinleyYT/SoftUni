using System.Collections.Generic;
using System.Text;
using _02.Blobs.Interfaces;

namespace _02.Blobs.Data
{
    public class Repository : IRepository
    {
        private IList<IBlob> blobs;

        public Repository()
        {
            this.blobs = new List<IBlob>();
        }

        public void AddUnit(IBlob blob)
        {
            this.blobs.Add(blob);
        }

        public string Status()
        {
            var sb = new StringBuilder();

            foreach (var blob in this.blobs)
            {
                sb.AppendLine(blob.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}