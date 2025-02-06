open Browser
open Fable.Core
open Scene

(*

Inspired by old-school retro games. Attempting my own retro-looking game.

Self-imposed limitations: 
- 16 colors
- pixel sprites/tiles, preferably < 64px
- audio, preferably 4 channels. Depends on available tools
- Keep it tiny, keep it simple
- Start without entity component system (for now)
- Platformer

*)


let createGame () =
    let pl t = ()
    let cr t = ()
    let upd t time delta = ()
        //console.log time
    let s = new Scene(None, pl, cr, upd)
    let conf = createConf s 800 600
    new Game(conf)

createGame () |> ignore