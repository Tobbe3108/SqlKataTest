using SqlKata.Compilers;

var compiler = new SqlServerCompiler();
var result = compiler.Compile(ClassLibrary1.RelationBuilder.Test);
Console.WriteLine(result.ToString());

// const string constr = "Server=.;Database=MasterAlmen;Trusted_Connection=True;TrustServerCertificate=True;";
//
// var db = new QueryFactory(new SqlConnection(constr), new SqlServerCompiler());
//
// var data = await db.GetAsync<ClassLibrary1.RelationBuilder.NewType>(ClassLibrary1.RelationBuilder.Test);

Console.WriteLine();