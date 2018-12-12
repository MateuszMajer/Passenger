$projects = @("Api","Core","Infrastructure","Tests","Tests.EndToEnd")
$solution="Passenger"

 foreach ($project in $projects) {
   cd $solution"."$project
   dotnet restore
   cd..
 }