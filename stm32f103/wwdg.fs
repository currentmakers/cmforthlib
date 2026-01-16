\
\ @file wwdg.fs
\ @brief Window watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register (WWDG_CR)
\ Address offset: 0x00
\ Reset value: 0x0000007F
\

$0000007f constant WWDG_CR_T                                        \ 7-bit counter (MSB to LSB)
$00000080 constant WWDG_CR_WDGA                                     \ Activation bit


\
\ @brief Configuration register (WWDG_CFR)
\ Address offset: 0x04
\ Reset value: 0x0000007F
\

$0000007f constant WWDG_CFR_W                                       \ 7-bit window value
$00000180 constant WWDG_CFR_WDGTB                                   \ Timer Base
$00000200 constant WWDG_CFR_EWI                                     \ Early Wakeup Interrupt


\
\ @brief Status register (WWDG_SR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant WWDG_SR_EWI                                      \ Early Wakeup Interrupt


\
\ @brief Window watchdog
\
$40002c00 constant WWDG_CR        \ offset: 0x00 : Control register (WWDG_CR)
$40002c04 constant WWDG_CFR       \ offset: 0x04 : Configuration register (WWDG_CFR)
$40002c08 constant WWDG_SR        \ offset: 0x08 : Status register (WWDG_SR)

