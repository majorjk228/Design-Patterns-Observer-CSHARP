using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Observer_CSHARP
{
    // Новость
    public sealed class News
    {
        public string Title { get; }
        public string Content { get; }

        public News(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
