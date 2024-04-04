
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport


type Director = {
    Name: string
    NumberOfMovies: int
}


type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}


let coda = {
    Name = "CODA"
    RunLength = 111
    Genre = Drama
    Director = { Name = "Sian Heder"; NumberOfMovies = 9 }
    IMDBRating = 8.1
}

let belfast = {
    Name = "Belfast"
    RunLength = 98
    Genre = Comedy
    Director = { Name = "Kenneth Branagh"; NumberOfMovies = 23 }
    IMDBRating = 7.3
}

let dontLookUp = {
    Name = "Don't Look Up"
    RunLength = 138
    Genre = Comedy
    Director = { Name = "Adam McKay"; NumberOfMovies = 27 }
    IMDBRating = 7.2
}

let driveMyCar = {
    Name = "Drive My Car"
    RunLength = 179
    Genre = Drama
    Director = { Name = "Ryusuke Hamaguchi"; NumberOfMovies = 16 }
    IMDBRating = 7.6
}

let dune = {
    Name = "Dune"
    RunLength = 155
    Genre = Fantasy
    Director = { Name = "Denis Villeneuve"; NumberOfMovies = 24 }
    IMDBRating = 8.1
}

let kingRichard = {
    Name = "King Richard"
    RunLength = 144
    Genre = Sport
    Director = { Name = "Reinaldo Marcus Green"; NumberOfMovies = 15 }
    IMDBRating = 7.5
}

let licoricePizza = {
    Name = "Licorice Pizza"
    RunLength = 133
    Genre = Comedy
    Director = { Name = "Paul Thomas Anderson"; NumberOfMovies = 49 }
    IMDBRating = 7.4
}

let nightmareAlley = {
    Name = "Nightmare Alley"
    RunLength = 150
    Genre = Thriller
    Director = { Name = "Guillermo Del Toro"; NumberOfMovies = 22 }
    IMDBRating = 7.1
}


let moviesList = [coda; belfast; dontLookUp; driveMyCar; dune; kingRichard; licoricePizza; nightmareAlley]


let probable_oscar_winners = 
    moviesList |> List.filter (fun movie -> movie.IMDBRating > 7.4)


let convertRunLengthWithName movie =
    let hours = movie.RunLength / 60
    let minutes = movie.RunLength % 60
    sprintf "%s: %dh %02dmin" movie.Name hours minutes

let moviesWithNameAndRunLengths = 
    moviesList |> List.map convertRunLengthWithName


printfn "\n Probable Oscar winners movies name"
probable_oscar_winners |> List.iter (fun movie ->printfn"%s"movie.Name)
printfn "\n Movies list with hours and minutes"
moviesWithNameAndRunLengths |> List.iter (printfn "%s")

