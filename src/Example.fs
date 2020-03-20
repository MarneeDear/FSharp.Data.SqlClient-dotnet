namespace lib

module example =

    open FSharp.Data

    [<Literal>]
    let connectionString = @"Data Source=(local);Initial Catalog=MyDatabase;Integrated Security=True"

    let get () =
        do
            use cmd = new SqlCommandProvider<"SELECT * FROM MYTABLE", connectionString>(connectionString)
            cmd.Execute() |> ignore
