\
\ @file sec_wwdg.fs
\ @brief System window watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register
\ Address offset: 0x00
\ Reset value: 0x0000007F
\

$0000007f constant SEC_WWDG_CR_T                                    \ 7-bit counter (MSB to LSB)
$00000080 constant SEC_WWDG_CR_WDGA                                 \ Activation bit


\
\ @brief Configuration register
\ Address offset: 0x04
\ Reset value: 0x0000007F
\

$0000007f constant SEC_WWDG_CFR_W                                   \ 7-bit window value
$00000200 constant SEC_WWDG_CFR_EWI                                 \ Early wakeup interrupt
$00003800 constant SEC_WWDG_CFR_WDGTB                               \ Timer base


\
\ @brief Status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_WWDG_SR_EWIF                                 \ Early wakeup interrupt flag


\
\ @brief System window watchdog
\
$50002c00 constant SEC_WWDG_CR    \ offset: 0x00 : Control register
$50002c04 constant SEC_WWDG_CFR   \ offset: 0x04 : Configuration register
$50002c08 constant SEC_WWDG_SR    \ offset: 0x08 : Status register

