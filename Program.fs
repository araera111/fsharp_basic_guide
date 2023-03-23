// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

// ダブルスラッシュ以降は1行コメント

(* これで囲まれたところもコメント *)

(*
  変数宣言
  再代入できません
*)
let mutable num = 1 // int
let str = "string" // string
let bool = false // bool

(* 再代入したいときはmutableにします *)
let mutable mutNum = 1
mutNum <- 2

printfn "%A" mutNum // 2

(* 二項演算子 *)
let r1 = 1 + 2 // 1 + 2 = 3
let r2 = 1 * 2 // 1 * 2 = 2
let r3 = 1.0 / 2.0 // 1.0 / 2.0 = 0.5
let r4 = 8 % 2 // 8 % 2 = 0

(* べき乗演算子はint型にはありません *)
let r5 = pown 2 4
printfn $"{r5}"

(* float型にはあるようです *)
let r6 = 2.0 ** 4.0
printfn $"{r6}"

(*
  比較演算子
  jsでの===は「=」だけです。代入ではなく比較になる。
  >,<, >=, <=は同じです。
  [!==]は[<>]です。SQLみたいですね。
 *)
let r7 = 2 = 7 // false
let r8 = 2 < 7
let r9 = 2 < 7
let r10 = 2 <= 7
let r11 = 2 >= 7
let r12 = 2 <> 7

(* 
  論理演算子
  TypeScriptと同様、&&や||などが使えます。
*)

let str1 = "str1"
let str2 = "str2"
let r13 = str1 = "str1" && str2 = "str2" //bool

(*
  NOT演算子はありませんがnot関数があります
  TypeScriptなら下記のように書いたりするが
  if(!boolVal) {
    boolValが逆転したときの処理
  }
 *)
let r14 = not (str1 = "str1") // false

(* 三項演算子はifが文ではなく式なので、そのまま書けます
  const val = false ? "A" : "B" => valはA
*)
let r15 = if false then "A" else "B"

(*  *)
