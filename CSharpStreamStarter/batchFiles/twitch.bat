@echo off
setlocal EnableDelayedExpansion
SET streamLink="C:\Program Files (x86)\Streamlink\bin\streamlink.exe"

:twitch
SET url=%1
SET quality=%2
SET videoID=%3

IF %videoID%==live (
	%streamLink% twitch.tv/%url% %quality% --twitch-low-latency
) ELSE (
	%streamLink% twitch.tv/%url%/v/%videoID% %quality%
)