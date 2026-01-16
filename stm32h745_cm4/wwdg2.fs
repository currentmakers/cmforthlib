\
\ @file wwdg2.fs
\ @brief Window Watchdog interrupt
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

$0000007f constant WWDG2_CR_T                                       \ 7-bit counter (MSB to LSB) These bits contain the value of the watchdog counter. It is decremented every (4096 x 2WDGTB[1:0]) PCLK cycles. A reset is produced when it is decremented from 0x40 to 0x3F (T6 becomes cleared).
$00000080 constant WWDG2_CR_WDGA                                    \ Activation bit This bit is set by software and only cleared by hardware after a reset. When WDGA=1, the watchdog can generate a reset.


\
\ @brief Configuration register
\ Address offset: 0x04
\ Reset value: 0x0000007F
\

$0000007f constant WWDG2_CFR_W                                      \ 7-bit window value These bits contain the window value to be compared to the downcounter.
$00000200 constant WWDG2_CFR_EWI                                    \ Early wakeup interrupt When set, an interrupt occurs whenever the counter reaches the value 0x40. This interrupt is only cleared by hardware after a reset.
$00001800 constant WWDG2_CFR_WDGTB                                  \ Timer base The time base of the prescaler can be modified as follows:


\
\ @brief Status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant WWDG2_SR_EWIF                                    \ Early wakeup interrupt flag This bit is set by hardware when the counter has reached the value 0x40. It must be cleared by software by writing 0. A write of 1 has no effect. This bit is also set if the interrupt is not enabled.


\
\ @brief Window Watchdog interrupt
\
$40002c00 constant WWDG2_CR       \ offset: 0x00 : Control register
$40002c04 constant WWDG2_CFR      \ offset: 0x04 : Configuration register
$40002c08 constant WWDG2_SR       \ offset: 0x08 : Status register

