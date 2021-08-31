@echo off
setlocal EnableDelayedExpansion
SET streamLink="C:\Program Files (x86)\Streamlink\bin\streamlink.exe"

:bbc
SET url=%1
SET quality=%2
SET liveFlag=%3
SET username=%4
SET password=%5
IF %liveFlag%==live (
	%streamLink% bbc.co.uk/iplayer/live/%url% %quality% --bbciplayer-username=%username% --bbciplayer-password=%password% --bbciplayer-hd
) ELSE (
	%streamLink% %url% %quality% --bbciplayer-username=%username% --bbciplayer-password=%password%
)