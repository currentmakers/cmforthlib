\
\ @file iwdg.fs
\ @brief Independent watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Key register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant IWDG_KR_KEY                                      \ Key value (write only, read 0x0000)


\
\ @brief Prescaler register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant IWDG_PR_PR                                       \ Prescaler divider


\
\ @brief Reload register
\ Address offset: 0x08
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_RLR_RL                                      \ Watchdog counter reload value


\
\ @brief Status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IWDG_SR_PVU                                      \ Watchdog prescaler value update
$00000002 constant IWDG_SR_RVU                                      \ Watchdog counter reload value update
$00000004 constant IWDG_SR_WVU                                      \ Watchdog counter window value update
$00000008 constant IWDG_SR_EWU                                      \ Watchdog interrupt comparator value update
$00004000 constant IWDG_SR_EWIF                                     \ Watchdog Early interrupt flag


\
\ @brief Window register
\ Address offset: 0x10
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG_WINR_WIN                                    \ Watchdog counter window value


\
\ @brief IWDG early wakeup interrupt register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant IWDG_EWCR_EWIT                                   \ Watchdog counter window value
$00004000 constant IWDG_EWCR_EWIC                                   \ Watchdog early interrupt acknowledge
$00008000 constant IWDG_EWCR_EWIE                                   \ Watchdog early interrupt enable


\
\ @brief Independent watchdog
\
$40003000 constant IWDG_KR        \ offset: 0x00 : Key register
$40003004 constant IWDG_PR        \ offset: 0x04 : Prescaler register
$40003008 constant IWDG_RLR       \ offset: 0x08 : Reload register
$4000300c constant IWDG_SR        \ offset: 0x0C : Status register
$40003010 constant IWDG_WINR      \ offset: 0x10 : Window register
$40003014 constant IWDG_EWCR      \ offset: 0x14 : IWDG early wakeup interrupt register

