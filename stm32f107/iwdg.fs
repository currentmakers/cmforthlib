\
\ @file iwdg.fs
\ @brief Independent watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Key register (IWDG_KR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant IWDG_KR_KEY                                      \ Key value


\
\ @brief Prescaler register (IWDG_PR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant IWDG_PR_PR                                       \ Prescaler divider


\
\ @brief Reload register (IWDG_RLR)
\ Address offset: 0x08
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_RLR_RL                                      \ Watchdog counter reload value


\
\ @brief Status register (IWDG_SR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IWDG_SR_PVU                                      \ Watchdog prescaler value update
$00000002 constant IWDG_SR_RVU                                      \ Watchdog counter reload value update


\
\ @brief Independent watchdog
\
$40003000 constant IWDG_KR        \ offset: 0x00 : Key register (IWDG_KR)
$40003004 constant IWDG_PR        \ offset: 0x04 : Prescaler register (IWDG_PR)
$40003008 constant IWDG_RLR       \ offset: 0x08 : Reload register (IWDG_RLR)
$4000300c constant IWDG_SR        \ offset: 0x0C : Status register (IWDG_SR)

