open System

open Exam2_2021
open Checker

let rec lineAlt (symbol1 : string) (symbol2 : string) (length : int) : string = ""

let rec zip (l1 : List<'a>) (l2 : List<'b>) : Option<List<'a * 'b>> = None

let graduationDocument (exams : List<ExamResult>) : GraduationReport = Ok
      
let rec fold2 (f : 'state -> 'a -> 'b -> 'state) (currentState : 'state) (l1 : List<'a>) (l2 : List<'b>) : Option<'state> = None

let mapGraph (f : 'a -> 'c) (graph : Graph<'a,'b>) : Graph<'c,'b> = { Edges = [] }



[<EntryPoint>]
let main argv =
  try
    let testedExercises =
      {
        Exercise1 = lineAlt
        Exercise2 = zip
        Exercise3 = graduationDocument
        Exercise4 = fold2
        Exercise5 = mapGraph
      }
    printfn "%s" (validate testedExercises)
    0
  with
  | CheckerException msg -> 
      printfn "%s" msg
      1
  | :? Exception as e ->
      printfn "EXCEPTION: %s \nSTACK TRACE: %s" e.Message e.StackTrace
      1