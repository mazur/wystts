-module(pingpong).
-export([start/0, ping/1, pong/0]).

ping(Pong_PID) ->
    Pong_PID ! {wolverine, self()},
    receive
        sabertooth ->
            io:format("I'm Wolverine!~n", [])
    end.

pong() ->
    receive
        {wolverine, Ping_PID} ->
            io:format("I'm Sabertooth!~n", []),
            Ping_PID ! sabertooth
    end.

start() ->
    Pong_PID = spawn(pingpong, pong, []),
    spawn(pingpong, ping, [Pong_PID]).