\
\ @file sec_wwdg.fs
\ @brief System window watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief WWDG control register
\ Address offset: 0x00
\ Reset value: 0x0000007F
\

$0000007f constant SEC_WWDG_WWDG_CR_T                               \ 7-bit counter (MSB to LSB) These bits contain the value of the watchdog counter, decremented every (4096 x 2supWDGTB[2:0]/sup) PCLK cycles. A reset is produced when it is decremented from 0x40 to 0x3F (T6 becomes cleared).
$00000080 constant SEC_WWDG_WWDG_CR_WDGA                            \ Activation bit This bit is set by software and only cleared by hardware after a reset. When WDGA = 1, the watchdog can generate a reset.


\
\ @brief WWDG configuration register
\ Address offset: 0x04
\ Reset value: 0x0000007F
\

$0000007f constant SEC_WWDG_WWDG_CFR_W                              \ 7-bit window value These bits contain the window value to be compared with the down-counter.
$00000200 constant SEC_WWDG_WWDG_CFR_EWI                            \ Early wakeup interrupt When set, an interrupt occurs whenever the counter reaches the value 0x40. This interrupt is only cleared by hardware after a reset.
$00003800 constant SEC_WWDG_WWDG_CFR_WDGTB                          \ Timer base The timebase of the prescaler can be modified as follows:


\
\ @brief WWDG status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_WWDG_WWDG_SR_EWIF                            \ Early wakeup interrupt flag This bit is set by hardware when the counter has reached the value 0x40. It must be cleared by software by writing 0. Writing 1 has no effect. This bit is also set if the interrupt is not enabled.


\
\ @brief System window watchdog
\
$50002c00 constant SEC_WWDG_WWDG_CR  \ offset: 0x00 : WWDG control register
$50002c04 constant SEC_WWDG_WWDG_CFR  \ offset: 0x04 : WWDG configuration register
$50002c08 constant SEC_WWDG_WWDG_SR  \ offset: 0x08 : WWDG status register

