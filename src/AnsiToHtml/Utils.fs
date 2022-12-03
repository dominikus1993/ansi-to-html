namespace AnsiToHtml

module internal FileUtils =
    open System.IO
    open System
    open System.Threading
    open System.Text
    
    let readToUnicode (path: string) (ct: CancellationToken) =
         File.ReadAllLinesAsync(path, Encoding.UTF8, ct)
