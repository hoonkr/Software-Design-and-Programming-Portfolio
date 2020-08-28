using System;
using System.Collections.Generic;

namespace Composite
{
    public interface HtmlTag
    {
        public void AddChildTag(HtmlTag htmlTag);
        public void RemoveChildTag(HtmlTag htmlTag);

        public string TagName { get; }
        public void TagBody(string tagBody);
        public void StartTag(string tag);
        public void EndTag(string tag);
        public List<HtmlTag> Children();

        public void GenerateHtml();
    }
}