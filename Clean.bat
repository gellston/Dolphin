setlocal



set CURPATH=%~dp0



pause

echo progressing deleting output directory...


rmdir %CURPATH%\Dolphin\.vs /S /Q
rmdir %CURPATH%\Dolphin\x64 /S /Q
rmdir %CURPATH%\Dolphin\Common\bin /S /Q
rmdir %CURPATH%\Dolphin\Common\obj /S /Q

rmdir %CURPATH%\Dolphin\Dolphin\bin /S /Q
rmdir %CURPATH%\Dolphin\Dolphin\obj /S /Q
rmdir %CURPATH%\Dolphin\Model\bin /S /Q
rmdir %CURPATH%\Dolphin\Model\obj /S /Q
rmdir %CURPATH%\Dolphin\Resources\bin /S /Q
rmdir %CURPATH%\Dolphin\Resources\obj /S /Q
rmdir %CURPATH%\Dolphin\Service\bin /S /Q
rmdir %CURPATH%\Dolphin\Service\obj /S /Q
rmdir %CURPATH%\Dolphin\View\bin /S /Q
rmdir %CURPATH%\Dolphin\View\obj /S /Q
rmdir %CURPATH%\Dolphin\ViewModel\bin /S /Q
rmdir %CURPATH%\Dolphin\ViewModel\obj /S /Q

rmdir %CURPATH%\Dolphin\DolphinAPI\x64 /S /Q
rmdir %CURPATH%\Dolphin\DolphinAPINET\x64 /S /Q
rmdir %CURPATH%\Dolphin\DolphinCommon\x64 /S /Q
rmdir %CURPATH%\Dolphin\DolphinDataLoader\x64 /S /Q




endlocal