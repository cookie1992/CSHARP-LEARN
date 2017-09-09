using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MvcUI.Extensions
{
    public static class BBCodeUtils
    {
        /// <summary>
        /// 替换一个字符串中换行符（一般为“\r\n”）成特定的字符串
        /// </summary>
        /// <param name="lines">当前字符串</param>
        /// <param name="replacement">要替换成的字符串</param>
        /// <returns></returns>
        public static string ReplaceLineBreaks(this string lines, string replacement)
        {
            if (string.IsNullOrEmpty(lines))
            {
                return lines;
            }
            return lines.Replace(Environment.NewLine, replacement);
        }

        /// <summary>
        /// 转换基本的 BBCode 代码到 HTML
        /// </summary>
        /// <param name="str">包含 BBCode 的字符串</param>
        /// <returns></returns>
        public static string ConvertBbCodeToHtml(this string str)
        {
            // As this is a BBEditor we need to replace line breaks
            // or they won't show in the front end
            str = ReplaceLineBreaks(str, "<br>");

            // format the bold tags: [b][/b]
            // becomes: <strong></strong>
            var exp = new Regex(@"\[b\](.+?)\[/b\]");
            str = exp.Replace(str, "<strong>$1</strong>");

            // format the italic tags: [i][/i]
            // becomes: <em></em>
            exp = new Regex(@"\[i\](.+?)\[/i\]");
            str = exp.Replace(str, "<em>$1</em>");

            // format the underline tags: [u][/u]
            // becomes: <u></u>
            exp = new Regex(@"\[u\](.+?)\[/u\]");
            str = exp.Replace(str, "<u>$1</u>");

            // format the underline tags: [ul][/ul]
            // becomes: <ul></ul>
            exp = new Regex(@"\[ul\](.+?)\[/ul\]");
            str = exp.Replace(str, "<ul>$1</ul>");

            // format the underline tags: [ol][/ol]
            // becomes: <ol></ol>
            exp = new Regex(@"\[ol\](.+?)\[/ol\]");
            str = exp.Replace(str, "<ol>$1</ol>");

            // format the underline tags: [li][/li]
            // becomes: <li></li>
            exp = new Regex(@"\[li\](.+?)\[/li\]");
            str = exp.Replace(str, "<li>$1</li>");

            // format the code tags: [code][/code]
            // becomes: <pre></pre>
            exp = new Regex(@"\[code\](.+?)\[/code\]");
            str = exp.Replace(str, "<pre>$1</pre>");

            // format the code tags: [quote][/quote]
            // becomes: <blockquote></blockquote>
            exp = new Regex(@"\[quote\](.+?)\[/quote\]");
            str = exp.Replace(str, "<blockquote>$1</blockquote>");

            // format the strike tags: [s][/s]
            // becomes: <strike></strike>
            exp = new Regex(@"\[s\](.+?)\[/s\]");
            str = exp.Replace(str, "<strike>$1</strike>");

            //### Before this replace links without http ###
            str.Replace("[url=www.", "[url=http://www.");
            // format the url tags: [url=www.website.com]my site[/url]
            // becomes: <a href="www.website.com">my site</a>
            exp = new Regex(@"\[url\=([^\]]+)\]([^\]]+)\[/url\]");
            str = exp.Replace(str, "<a rel=\"nofollow\" href=\"$1\">$2</a>");

            // format the img tags: [img]www.website.com/img/image.jpeg[/img]
            // becomes: <img src="www.website.com/img/image.jpeg" />
            exp = new Regex(@"\[img\]([^\]]+)\[/img\]");
            str = exp.Replace(str, "<img src=\"$1\" />");

            // format img tags with alt: [img=www.website.com/img/image.jpeg]this is the alt text[/img]
            // becomes: <img src="www.website.com/img/image.jpeg" alt="this is the alt text" />
            exp = new Regex(@"\[img\=([^\]]+)\]([^\]]+)\[/img\]");
            str = exp.Replace(str, "<img src=\"$1\" alt=\"$2\" />");

            // format the size tags: [size=1.2][/size]
            // becomes: <span style="font-size:1.2em;"></span>
            exp = new Regex(@"\[size\=([^\]]+)\]([^\]]+)\[/size\]");
            str = exp.Replace(str, "<span style=\"font-size:$1em;\">$2</span>");

            return str;
        }
    }
}
