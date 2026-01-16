\
\ @file gfxtim.fs
\ @brief GFXTIM register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GFXTIM configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant GFXTIM_GFXTIM_CR_TES                             \ tearing source This field selects the tearing-effect source.
$00000010 constant GFXTIM_GFXTIM_CR_TEPOL                           \ tearing--effect polarity This bit selects the tearing-effect polarity.
$00000300 constant GFXTIM_GFXTIM_CR_SYNCS                           \ synchronization source This field selects the synchronization signals (HSYNC and VSYNC) sources.
$00010000 constant GFXTIM_GFXTIM_CR_FCCOE                           \ frame-clock calibration output enable This bit enables the frame-clock output.
$00020000 constant GFXTIM_GFXTIM_CR_LCCOE                           \ line-clock calibration output enable This bit enables the line-clock output.


\
\ @brief GFXTIM clock generator configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant GFXTIM_GFXTIM_CGCR_LCS                           \ line clock source This field configures the line clock source.
$00000010 constant GFXTIM_GFXTIM_CGCR_LCCCS                         \ line clock counter clock source This bit configures the clock source for the line clock counter.
$00000100 constant GFXTIM_GFXTIM_CGCR_LCCFR                         \ line clock counter force reload This bit forces line clock counter reload.
$00007000 constant GFXTIM_GFXTIM_CGCR_LCCHRS                        \ line clock counter hardware reload source This field configures the hardware reload source for the line clock counter.
$00070000 constant GFXTIM_GFXTIM_CGCR_FCS                           \ frame clock source This field configures the frame clock source
$00700000 constant GFXTIM_GFXTIM_CGCR_FCCCS                         \ frame clock counter clock source This field configures the clock source for the frame clock counter.
$01000000 constant GFXTIM_GFXTIM_CGCR_FCCFR                         \ frame clock counter force reload This bit forces frame clock counter reload
$70000000 constant GFXTIM_GFXTIM_CGCR_FCCHRS                        \ frame- -clock counter hardware reload source This field configures the hardware reload source for the frame- -clock counter.


\
\ @brief GFXTIM timers configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_TCR_AFCEN                          \ absolute frame counter enable This bit enables the absolute frame counter.
$00000002 constant GFXTIM_GFXTIM_TCR_FAFCR                          \ force absolute frame counter reset This bit forces the reset of the absolute frame counter.
$00000010 constant GFXTIM_GFXTIM_TCR_ALCEN                          \ absolute line counter enable This bit enables the absolute line counter.
$00000020 constant GFXTIM_GFXTIM_TCR_FALCR                          \ force absolute line counter reset This bit forces the reset of the absolute line counter.
$00010000 constant GFXTIM_GFXTIM_TCR_RFC1EN                         \ relative frame counter 1 enable This bit enables the relative frame counter 1.
$00020000 constant GFXTIM_GFXTIM_TCR_RFC1CM                         \ relative frame counter 1 continuous mode This bit enables the continuous mode of the relative frame counter 1.
$00040000 constant GFXTIM_GFXTIM_TCR_FRFC1R                         \ force relative frame counter 1 reload This bit forces the reload of the relative frame counter 1.
$00100000 constant GFXTIM_GFXTIM_TCR_RFC2EN                         \ relative frame counter 2 enable This bit enables the relative frame counter 2.
$00200000 constant GFXTIM_GFXTIM_TCR_RFC2CM                         \ relative frame counter 2 continuous mode This bit enables the continuous mode of the relative frame counter 2.
$00400000 constant GFXTIM_GFXTIM_TCR_FRFC2R                         \ force relative frame counter 2 reload This bit forces the reload of the relative frame counter 2.


\
\ @brief GFXTIM timers disable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_TDR_AFCDIS                         \ absolute frame counter disable This bit disables the absolute frame counter.
$00000010 constant GFXTIM_GFXTIM_TDR_ALCDIS                         \ absolute line counter disable This bit disables the absolute line counter.
$00010000 constant GFXTIM_GFXTIM_TDR_RFC1DIS                        \ relative frame counter 1 disable This bit disables the relative frame counter 1.
$00100000 constant GFXTIM_GFXTIM_TDR_RFC2DIS                        \ relative frame counter 2 disable This bit disables the relative frame counter 2.


\
\ @brief GFXTIM events control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_EVCR_EV1EN                         \ event 1 enable This bit enables the complex event 1 generation.
$00000002 constant GFXTIM_GFXTIM_EVCR_EV2EN                         \ event 2 enable This bit enables the complex event 2 generation.
$00000004 constant GFXTIM_GFXTIM_EVCR_EV3EN                         \ event 3 enable This bit enables the complex event 3 generation.
$00000008 constant GFXTIM_GFXTIM_EVCR_EV4EN                         \ event 4 enable This bit enables the complex event 4 generation.


\
\ @brief GFXTIM events selection register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant GFXTIM_GFXTIM_EVSR_LES1                          \ line-event selection 1 This field defines the line-event selection for complex event 1 generation. others: reserved
$00000070 constant GFXTIM_GFXTIM_EVSR_FES1                          \ frame-event selection 1 This field defines the frame-event selection for complex event 1 generation. others: reserved
$00000700 constant GFXTIM_GFXTIM_EVSR_LES2                          \ line-event selection 2 This field defines the line-event selection for complex event 2 generation. others: reserved
$00007000 constant GFXTIM_GFXTIM_EVSR_FES2                          \ frame-event selection 2 This field defines the frame-event selection for complex event 2 generation. others: reserved
$00070000 constant GFXTIM_GFXTIM_EVSR_LES3                          \ line-event selection 3 This field defines the line-event selection for complex event 3 generation. others: reserved
$00700000 constant GFXTIM_GFXTIM_EVSR_FES3                          \ frame-event selection 3 This field defines the frame-event selection for complex event 3 generation. others: reserved
$07000000 constant GFXTIM_GFXTIM_EVSR_LES4                          \ line-event selection 4 This field defines the line-event selection for complex event 4 generation. others: Reserved
$70000000 constant GFXTIM_GFXTIM_EVSR_FES4                          \ frame-event selection 4 This field defines the frame-event selection for complex event 4 generation. others: reserved


\
\ @brief GFXTIM watchdog timer configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_WDGTCR_WDGEN                       \ watchdog enable This bit enables the graphic watchdog.
$00000002 constant GFXTIM_GFXTIM_WDGTCR_WDGDIS                      \ watchdog disable This bit disables the graphic watchdog.
$00000004 constant GFXTIM_GFXTIM_WDGTCR_WDGS                        \ watchdog status This bit returns the status of the graphic watchdog.
$00000030 constant GFXTIM_GFXTIM_WDGTCR_WDGHRC                      \ watchdog hardware reload configuration This field configures the watchdog hardware reload.
$00000f00 constant GFXTIM_GFXTIM_WDGTCR_WDGCS                       \ watchdog clock source This field selects the watchdog clock source. others: reserved
$00010000 constant GFXTIM_GFXTIM_WDGTCR_FWDGR                       \ force watchdog reload This bit forces the reload of the graphic watchdog.


\
\ @brief GFXTIM interrupt status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_ISR_AFCOF                          \ absolute frame counter overflow flag This bit indicates an overflow occurred on the absolute frame counter.
$00000002 constant GFXTIM_GFXTIM_ISR_ALCOF                          \ absolute line counter overflow flag This bit indicates an overflow occurred on the absolute line counter.
$00000004 constant GFXTIM_GFXTIM_ISR_TEF                            \ tearing-effect flag This bit indicates a tearing effect event occurred.
$00000010 constant GFXTIM_GFXTIM_ISR_AFCC1F                         \ absolute frame counter compare 1 flag This bit indicates match on compare 1 of the absolute frame counter.
$00000100 constant GFXTIM_GFXTIM_ISR_ALCC1F                         \ absolute line counter compare 1 flag This bit indicates match on compare 1 of the absolute line counter.
$00000200 constant GFXTIM_GFXTIM_ISR_ALCC2F                         \ absolute line counter compare 2 flag This bit indicates match on compare 2 of the absolute line counter.
$00001000 constant GFXTIM_GFXTIM_ISR_RFC1RF                         \ relative frame counter 1 reload flag This bit indicates relative frame counter 1 has been reloaded.
$00002000 constant GFXTIM_GFXTIM_ISR_RFC2RF                         \ relative frame counter 2 reload flag This bit indicates relative frame counter 2 has been reloaded.
$00010000 constant GFXTIM_GFXTIM_ISR_EV1F                           \ event 1 flag This bit indicates a complex event 1 occurred.
$00020000 constant GFXTIM_GFXTIM_ISR_EV2F                           \ event 2 flag This bit indicates a complex event 2 occurred.
$00040000 constant GFXTIM_GFXTIM_ISR_EV3F                           \ event 3 flag This bit indicates a complex event 3 occurred.
$00080000 constant GFXTIM_GFXTIM_ISR_EV4F                           \ event 4 flag This bit indicates a complex event 4 occurred.
$01000000 constant GFXTIM_GFXTIM_ISR_WDGAF                          \ watchdog alarm flag This bit indicates that a graphic watchdog alarm occurred.
$02000000 constant GFXTIM_GFXTIM_ISR_WDGPF                          \ watchdog pre-alarm flag This bit indicates that a graphic watchdog pre-alarm occurred.


\
\ @brief GFXTIM interrupt clear register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_ICR_CAFCOF                         \ clear absolute frame counter overflow flag This bit clears AFCOF in GXTIM_ISR.
$00000002 constant GFXTIM_GFXTIM_ICR_CALCOF                         \ clear absolute line counter overflow flag This bit clears ALCOF in GXTIM_ISR.
$00000004 constant GFXTIM_GFXTIM_ICR_CTEF                           \ clear tearing-effect flag This bit clears TEF in GXTIM_ISR.
$00000010 constant GFXTIM_GFXTIM_ICR_CAFCC1F                        \ clear absolute frame counter compare 1 flag This bit clears AFCC1F in GXTIM_ISR.
$00000100 constant GFXTIM_GFXTIM_ICR_CALCC1F                        \ clear absolute line counter compare 1 flag This bit clears ALCC1F in GXTIM_ISR.
$00000200 constant GFXTIM_GFXTIM_ICR_CALCC2F                        \ clear absolute line counter compare 2 flag This bit clears ALCC2F in GXTIM_ISR.
$00001000 constant GFXTIM_GFXTIM_ICR_CRFC1RF                        \ clear relative frame counter 1 reload flag This bit clears RFC1RF in GXTIM_ISR.
$00002000 constant GFXTIM_GFXTIM_ICR_CRFC2RF                        \ clear relative frame counter 2 reload flag This bit clears RFC2RF in GXFXTIM_ISR.
$00010000 constant GFXTIM_GFXTIM_ICR_CEV1F                          \ clear event 1 flag This bit EV1F in GXFXTIM_ISR.
$00020000 constant GFXTIM_GFXTIM_ICR_CEV2F                          \ clear event 2 flag This bit clears EV2F in GXFXTIM_ISR.
$00040000 constant GFXTIM_GFXTIM_ICR_CEV3F                          \ clear event 3 flag This bit clears EV3F in GXFXTIM_ISR.
$00080000 constant GFXTIM_GFXTIM_ICR_CEV4F                          \ clear event 4 flag This bit clears EV4F in GXFXTIM_ISR.
$01000000 constant GFXTIM_GFXTIM_ICR_CWDGAF                         \ clear watchdog alarm flag This bit clears WDGAF in GXFXTIM_ISR.
$02000000 constant GFXTIM_GFXTIM_ICR_CWDGPF                         \ clear watchdog pre-alarm flag This bit clears WDGPF in GXFXTIM_ISR.


\
\ @brief GFXTIM interrupt enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_IER_AFCOIE                         \ absolute frame counter overflow interrupt enable This bit enables the absolute frame counter overflow interrupt generation.
$00000002 constant GFXTIM_GFXTIM_IER_ALCOIE                         \ absolute line counter overflow interrupt enable This bit enables the absolute line counter overflow interrupt generation.
$00000004 constant GFXTIM_GFXTIM_IER_TEIE                           \ tearing-effect interrupt enable This bit enables the Tearing Effect interrupt generation.
$00000010 constant GFXTIM_GFXTIM_IER_AFCC1IE                        \ absolute frame counter compare 1 interrupt enable This bit enables the absolute frame counter compare interrupt generation.
$00000100 constant GFXTIM_GFXTIM_IER_ALCC1IE                        \ absolute line counter compare 1 interrupt enable This bit enables the absolute line counter compare 1 interrupt generation.
$00000200 constant GFXTIM_GFXTIM_IER_ALCC2IE                        \ absolute line counter compare 2 interrupt enable This bit enables the absolute line counter compare 2 interrupt generation.
$00001000 constant GFXTIM_GFXTIM_IER_RFC1RIE                        \ relative frame counter 1 reload interrupt enable This bit enables the relative frame counter 1 reload interrupt generation.
$00002000 constant GFXTIM_GFXTIM_IER_RFC2RIE                        \ relative frame counter 2 reload interrupt enable This bit enables the relative frame counter 2 reload interrupt generation.
$00010000 constant GFXTIM_GFXTIM_IER_EV1IE                          \ event 1 interrupt enable This bit enables the complex event 1 interrupt generation.
$00020000 constant GFXTIM_GFXTIM_IER_EV2IE                          \ event 2 interrupt enable This bit enables the complex event 2 interrupt generation.
$00040000 constant GFXTIM_GFXTIM_IER_EV3IE                          \ event 3 interrupt enable This bit enables the complex event 3 interrupt generation.
$00080000 constant GFXTIM_GFXTIM_IER_EV4IE                          \ event 4 interrupt enable This bit enables the complex event 4 interrupt generation.
$01000000 constant GFXTIM_GFXTIM_IER_WDGAIE                         \ watchdog alarm interrupt enable This bit enables the watchdog alarm interrupt generation.
$02000000 constant GFXTIM_GFXTIM_IER_WDGPIE                         \ watchdog pre-alarm interrupt enable This bit enables the watchdog pre-alarm interrupt generation.


\
\ @brief GFXTIM timers status register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_GFXTIM_TSR_AFCS                           \ absolute frame counter status This bit returns the status of the absolute frame counter.
$00000010 constant GFXTIM_GFXTIM_TSR_ALCS                           \ absolute line counter status This bit returns the status of the absolute line counter.
$00010000 constant GFXTIM_GFXTIM_TSR_RFC1S                          \ relative frame counter 1 status This bit returns the status of the relative frame counter 1.
$00100000 constant GFXTIM_GFXTIM_TSR_RFC2S                          \ relative frame counter 2 status This bit returns the status of the relative frame counter 2.


\
\ @brief GFXTIM line clock counter reload register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$003fffff constant GFXTIM_GFXTIM_LCCRR_RELOAD                       \ reload value Reload value of the line clock counter.


\
\ @brief GFXTIM frame clock counter reload register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_FCCRR_RELOAD                       \ reload value Reload value of the frame clock counter.


\
\ @brief GFXTIM absolute time register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_ATR_LINE                           \ line number Current value of the absolute line counter.
$fffff000 constant GFXTIM_GFXTIM_ATR_FRAME                          \ fame number Current value of the absolute frame counter.


\
\ @brief GFXTIM absolute frame counter register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000fffff constant GFXTIM_GFXTIM_AFCR_FRAME                         \ frame number Current value of the absolute frame counter. Note: This field can only be written when the absolute frame counter is disabled.


\
\ @brief GFXTIM absolute line counter register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_ALCR_LINE                          \ line number Current value of the absolute line counter. Note: This field can only be written when the absolute frame counter is disabled.


\
\ @brief GFXTIM absolute frame counter compare 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000fffff constant GFXTIM_GFXTIM_AFCC1R_FRAME                       \ frame number Compare 1 value for the absolute frame counter.


\
\ @brief GFXTIM absolute line counter compare 1 register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_ALCC1R_LINE                        \ line number Compare value 1 for the absolute line counter.


\
\ @brief GFXTIM absolute line counter compare 2 register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_ALCC2R_LINE                        \ line number Compare value 2 for the absolute line counter.


\
\ @brief GFXTIM relative frame counter 1 register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_RFC1R_FRAME                        \ frame number Current value of the relative frame counter 1.


\
\ @brief GFXTIM relative frame counter 1 reload register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_RFC1RR_FRAME                       \ frame reload value Reload value for the relative frame counter 1.


\
\ @brief GFXTIM relative frame counter 2 register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_RFC2R_FRAME                        \ frame number Current value of the relative frame counter 2.


\
\ @brief GFXTIM relative frame counter 2 reload register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_GFXTIM_RFC2RR_FRAME                       \ frame reload value Reload value for the relative frame counter 2.


\
\ @brief GFXTIM watchdog counter register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000ffff constant GFXTIM_GFXTIM_WDGCR_VALUE                        \ value Current value of the watchdog counter.


\
\ @brief GFXTIM watchdog reload register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant GFXTIM_GFXTIM_WDGRR_RELOAD                       \ reload value Reload value of the watchdog counter.


\
\ @brief GFXTIM watchdog pre-alarm register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000ffff constant GFXTIM_GFXTIM_WDGPAR_PREALARM                    \ pre-alarm value Pre-alarm value of the watchdog counter.


\
\ @brief GFXTIM register block
\
$40016400 constant GFXTIM_GFXTIM_CR  \ offset: 0x00 : GFXTIM configuration register
$40016404 constant GFXTIM_GFXTIM_CGCR  \ offset: 0x04 : GFXTIM clock generator configuration register
$40016408 constant GFXTIM_GFXTIM_TCR  \ offset: 0x08 : GFXTIM timers configuration register
$4001640c constant GFXTIM_GFXTIM_TDR  \ offset: 0x0C : GFXTIM timers disable register
$40016410 constant GFXTIM_GFXTIM_EVCR  \ offset: 0x10 : GFXTIM events control register
$40016414 constant GFXTIM_GFXTIM_EVSR  \ offset: 0x14 : GFXTIM events selection register
$40016420 constant GFXTIM_GFXTIM_WDGTCR  \ offset: 0x20 : GFXTIM watchdog timer configuration register
$40016430 constant GFXTIM_GFXTIM_ISR  \ offset: 0x30 : GFXTIM interrupt status register
$40016434 constant GFXTIM_GFXTIM_ICR  \ offset: 0x34 : GFXTIM interrupt clear register
$40016438 constant GFXTIM_GFXTIM_IER  \ offset: 0x38 : GFXTIM interrupt enable register
$4001643c constant GFXTIM_GFXTIM_TSR  \ offset: 0x3C : GFXTIM timers status register
$40016440 constant GFXTIM_GFXTIM_LCCRR  \ offset: 0x40 : GFXTIM line clock counter reload register
$40016444 constant GFXTIM_GFXTIM_FCCRR  \ offset: 0x44 : GFXTIM frame clock counter reload register
$40016450 constant GFXTIM_GFXTIM_ATR  \ offset: 0x50 : GFXTIM absolute time register
$40016454 constant GFXTIM_GFXTIM_AFCR  \ offset: 0x54 : GFXTIM absolute frame counter register
$40016458 constant GFXTIM_GFXTIM_ALCR  \ offset: 0x58 : GFXTIM absolute line counter register
$40016460 constant GFXTIM_GFXTIM_AFCC1R  \ offset: 0x60 : GFXTIM absolute frame counter compare 1 register
$40016470 constant GFXTIM_GFXTIM_ALCC1R  \ offset: 0x70 : GFXTIM absolute line counter compare 1 register
$40016474 constant GFXTIM_GFXTIM_ALCC2R  \ offset: 0x74 : GFXTIM absolute line counter compare 2 register
$40016480 constant GFXTIM_GFXTIM_RFC1R  \ offset: 0x80 : GFXTIM relative frame counter 1 register
$40016484 constant GFXTIM_GFXTIM_RFC1RR  \ offset: 0x84 : GFXTIM relative frame counter 1 reload register
$40016488 constant GFXTIM_GFXTIM_RFC2R  \ offset: 0x88 : GFXTIM relative frame counter 2 register
$4001648c constant GFXTIM_GFXTIM_RFC2RR  \ offset: 0x8C : GFXTIM relative frame counter 2 reload register
$400164a0 constant GFXTIM_GFXTIM_WDGCR  \ offset: 0xA0 : GFXTIM watchdog counter register
$400164a4 constant GFXTIM_GFXTIM_WDGRR  \ offset: 0xA4 : GFXTIM watchdog reload register
$400164a8 constant GFXTIM_GFXTIM_WDGPAR  \ offset: 0xA8 : GFXTIM watchdog pre-alarm register

