$projects = @("Tests","Tests.EndToEnd")
$solution="Passenger"

 foreach ($project in $projects) {
   cd $solution"."$project
   dotnet test
   cd..
 }