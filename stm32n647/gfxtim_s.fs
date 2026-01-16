\
\ @file gfxtim_s.fs
\ @brief Graphic timer
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

$00000003 constant GFXTIM_S_GFXTIM_CR_TES                           \ tearing source
$00000010 constant GFXTIM_S_GFXTIM_CR_TEPOL                         \ tearing--effect polarity
$00000300 constant GFXTIM_S_GFXTIM_CR_SYNCS                         \ synchronization source
$00010000 constant GFXTIM_S_GFXTIM_CR_FCCOE                         \ frame-clock calibration output enable
$00020000 constant GFXTIM_S_GFXTIM_CR_LCCOE                         \ line-clock calibration output enable


\
\ @brief GFXTIM clock generator configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant GFXTIM_S_GFXTIM_CGCR_LCS                         \ line clock source
$00000010 constant GFXTIM_S_GFXTIM_CGCR_LCCCS                       \ line clock counter clock source
$00000100 constant GFXTIM_S_GFXTIM_CGCR_LCCFR                       \ line clock counter force reload
$00007000 constant GFXTIM_S_GFXTIM_CGCR_LCCHRS                      \ line clock counter hardware reload source
$00070000 constant GFXTIM_S_GFXTIM_CGCR_FCS                         \ frame clock source
$00700000 constant GFXTIM_S_GFXTIM_CGCR_FCCCS                       \ frame clock counter clock source
$01000000 constant GFXTIM_S_GFXTIM_CGCR_FCCFR                       \ frame clock counter force reload
$70000000 constant GFXTIM_S_GFXTIM_CGCR_FCCHRS                      \ frame- -clock counter hardware reload source


\
\ @brief GFXTIM timers configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_TCR_AFCEN                        \ absolute frame counter enable
$00000002 constant GFXTIM_S_GFXTIM_TCR_FAFCR                        \ force absolute frame counter reset
$00000010 constant GFXTIM_S_GFXTIM_TCR_ALCEN                        \ absolute line counter enable
$00000020 constant GFXTIM_S_GFXTIM_TCR_FALCR                        \ force absolute line counter reset
$00010000 constant GFXTIM_S_GFXTIM_TCR_RFC1EN                       \ relative frame counter 1 enable
$00020000 constant GFXTIM_S_GFXTIM_TCR_RFC1CM                       \ relative frame counter 1 continuous mode
$00040000 constant GFXTIM_S_GFXTIM_TCR_FRFC1R                       \ force relative frame counter 1 reload
$00100000 constant GFXTIM_S_GFXTIM_TCR_RFC2EN                       \ relative frame counter 2 enable
$00200000 constant GFXTIM_S_GFXTIM_TCR_RFC2CM                       \ relative frame counter 2 continuous mode
$00400000 constant GFXTIM_S_GFXTIM_TCR_FRFC2R                       \ force relative frame counter 2 reload


\
\ @brief GFXTIM timers disable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_TDR_AFCDIS                       \ absolute frame counter disable
$00000010 constant GFXTIM_S_GFXTIM_TDR_ALCDIS                       \ absolute line counter disable
$00010000 constant GFXTIM_S_GFXTIM_TDR_RFC1DIS                      \ relative frame counter 1 disable
$00100000 constant GFXTIM_S_GFXTIM_TDR_RFC2DIS                      \ relative frame counter 2 disable


\
\ @brief GFXTIM events control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_EVCR_EV1EN                       \ event 1 enable
$00000002 constant GFXTIM_S_GFXTIM_EVCR_EV2EN                       \ event 2 enable
$00000004 constant GFXTIM_S_GFXTIM_EVCR_EV3EN                       \ event 3 enable
$00000008 constant GFXTIM_S_GFXTIM_EVCR_EV4EN                       \ event 4 enable


\
\ @brief GFXTIM events selection register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant GFXTIM_S_GFXTIM_EVSR_LES1                        \ line-event selection 1
$00000070 constant GFXTIM_S_GFXTIM_EVSR_FES1                        \ frame-event selection 1
$00000700 constant GFXTIM_S_GFXTIM_EVSR_LES2                        \ line-event selection 2
$00007000 constant GFXTIM_S_GFXTIM_EVSR_FES2                        \ frame-event selection 2
$00070000 constant GFXTIM_S_GFXTIM_EVSR_LES3                        \ line-event selection 3
$00700000 constant GFXTIM_S_GFXTIM_EVSR_FES3                        \ frame-event selection 3
$07000000 constant GFXTIM_S_GFXTIM_EVSR_LES4                        \ line-event selection 4
$70000000 constant GFXTIM_S_GFXTIM_EVSR_FES4                        \ frame-event selection 4


\
\ @brief GFXTIM watchdog timer configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_WDGTCR_WDGEN                     \ watchdog enable
$00000002 constant GFXTIM_S_GFXTIM_WDGTCR_WDGDIS                    \ watchdog disable
$00000004 constant GFXTIM_S_GFXTIM_WDGTCR_WDGS                      \ watchdog status
$00000030 constant GFXTIM_S_GFXTIM_WDGTCR_WDGHRC                    \ watchdog hardware reload configuration
$00000f00 constant GFXTIM_S_GFXTIM_WDGTCR_WDGCS                     \ watchdog clock source
$00010000 constant GFXTIM_S_GFXTIM_WDGTCR_FWDGR                     \ force watchdog reload


\
\ @brief GFXTIM interrupt status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_ISR_AFCOF                        \ absolute frame counter overflow flag
$00000002 constant GFXTIM_S_GFXTIM_ISR_ALCOF                        \ absolute line counter overflow flag
$00000004 constant GFXTIM_S_GFXTIM_ISR_TEF                          \ tearing-effect flag
$00000010 constant GFXTIM_S_GFXTIM_ISR_AFCC1F                       \ absolute frame counter compare 1 flag
$00000100 constant GFXTIM_S_GFXTIM_ISR_ALCC1F                       \ absolute line counter compare 1 flag
$00000200 constant GFXTIM_S_GFXTIM_ISR_ALCC2F                       \ absolute line counter compare 2 flag
$00001000 constant GFXTIM_S_GFXTIM_ISR_RFC1RF                       \ relative frame counter 1 reload flag
$00002000 constant GFXTIM_S_GFXTIM_ISR_RFC2RF                       \ relative frame counter 2 reload flag
$00010000 constant GFXTIM_S_GFXTIM_ISR_EV1F                         \ event 1 flag
$00020000 constant GFXTIM_S_GFXTIM_ISR_EV2F                         \ event 2 flag
$00040000 constant GFXTIM_S_GFXTIM_ISR_EV3F                         \ event 3 flag
$00080000 constant GFXTIM_S_GFXTIM_ISR_EV4F                         \ event 4 flag
$01000000 constant GFXTIM_S_GFXTIM_ISR_WDGAF                        \ watchdog alarm flag
$02000000 constant GFXTIM_S_GFXTIM_ISR_WDGPF                        \ watchdog pre-alarm flag


\
\ @brief GFXTIM interrupt clear register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_ICR_CAFCOF                       \ clear absolute frame counter overflow flag
$00000002 constant GFXTIM_S_GFXTIM_ICR_CALCOF                       \ clear absolute line counter overflow flag
$00000004 constant GFXTIM_S_GFXTIM_ICR_CTEF                         \ clear tearing-effect flag
$00000010 constant GFXTIM_S_GFXTIM_ICR_CAFCC1F                      \ clear absolute frame counter compare 1 flag
$00000100 constant GFXTIM_S_GFXTIM_ICR_CALCC1F                      \ clear absolute line counter compare 1 flag
$00000200 constant GFXTIM_S_GFXTIM_ICR_CALCC2F                      \ clear absolute line counter compare 2 flag
$00001000 constant GFXTIM_S_GFXTIM_ICR_CRFC1RF                      \ clear relative frame counter 1 reload flag
$00002000 constant GFXTIM_S_GFXTIM_ICR_CRFC2RF                      \ clear relative frame counter 2 reload flag
$00010000 constant GFXTIM_S_GFXTIM_ICR_CEV1F                        \ clear event 1 flag
$00020000 constant GFXTIM_S_GFXTIM_ICR_CEV2F                        \ clear event 2 flag
$00040000 constant GFXTIM_S_GFXTIM_ICR_CEV3F                        \ clear event 3 flag
$00080000 constant GFXTIM_S_GFXTIM_ICR_CEV4F                        \ clear event 4 flag
$01000000 constant GFXTIM_S_GFXTIM_ICR_CWDGAF                       \ clear watchdog alarm flag
$02000000 constant GFXTIM_S_GFXTIM_ICR_CWDGPF                       \ clear watchdog pre-alarm flag


\
\ @brief GFXTIM interrupt enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_IER_AFCOIE                       \ absolute frame counter overflow interrupt enable
$00000002 constant GFXTIM_S_GFXTIM_IER_ALCOIE                       \ absolute line counter overflow interrupt enable
$00000004 constant GFXTIM_S_GFXTIM_IER_TEIE                         \ tearing-effect interrupt enable
$00000010 constant GFXTIM_S_GFXTIM_IER_AFCC1IE                      \ absolute frame counter compare 1 interrupt enable
$00000100 constant GFXTIM_S_GFXTIM_IER_ALCC1IE                      \ absolute line counter compare 1 interrupt enable
$00000200 constant GFXTIM_S_GFXTIM_IER_ALCC2IE                      \ absolute line counter compare 2 interrupt enable
$00001000 constant GFXTIM_S_GFXTIM_IER_RFC1RIE                      \ relative frame counter 1 reload interrupt enable
$00002000 constant GFXTIM_S_GFXTIM_IER_RFC2RIE                      \ relative frame counter 2 reload interrupt enable
$00010000 constant GFXTIM_S_GFXTIM_IER_EV1IE                        \ event 1 interrupt enable
$00020000 constant GFXTIM_S_GFXTIM_IER_EV2IE                        \ event 2 interrupt enable
$00040000 constant GFXTIM_S_GFXTIM_IER_EV3IE                        \ event 3 interrupt enable
$00080000 constant GFXTIM_S_GFXTIM_IER_EV4IE                        \ event 4 interrupt enable
$01000000 constant GFXTIM_S_GFXTIM_IER_WDGAIE                       \ watchdog alarm interrupt enable
$02000000 constant GFXTIM_S_GFXTIM_IER_WDGPIE                       \ watchdog pre-alarm interrupt enable


\
\ @brief GFXTIM timers status register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant GFXTIM_S_GFXTIM_TSR_AFCS                         \ absolute frame counter status
$00000010 constant GFXTIM_S_GFXTIM_TSR_ALCS                         \ absolute line counter status
$00010000 constant GFXTIM_S_GFXTIM_TSR_RFC1S                        \ relative frame counter 1 status
$00100000 constant GFXTIM_S_GFXTIM_TSR_RFC2S                        \ relative frame counter 2 status


\
\ @brief GFXTIM line clock counter reload register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$003fffff constant GFXTIM_S_GFXTIM_LCCRR_RELOAD                     \ reload value


\
\ @brief GFXTIM frame clock counter reload register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_FCCRR_RELOAD                     \ reload value


\
\ @brief GFXTIM absolute time register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_ATR_LINE                         \ line number
$fffff000 constant GFXTIM_S_GFXTIM_ATR_FRAME                        \ fame number


\
\ @brief GFXTIM absolute frame counter register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000fffff constant GFXTIM_S_GFXTIM_AFCR_FRAME                       \ frame number


\
\ @brief GFXTIM absolute line counter register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_ALCR_LINE                        \ line number


\
\ @brief GFXTIM absolute frame counter compare 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000fffff constant GFXTIM_S_GFXTIM_AFCC1R_FRAME                     \ frame number


\
\ @brief GFXTIM absolute line counter compare 1 register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_ALCC1R_LINE                      \ line number


\
\ @brief GFXTIM absolute line counter compare 2 register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_ALCC2R_LINE                      \ line number


\
\ @brief GFXTIM relative frame counter 1 register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_RFC1R_FRAME                      \ frame number


\
\ @brief GFXTIM relative frame counter 1 reload register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_RFC1RR_FRAME                     \ frame reload value


\
\ @brief GFXTIM relative frame counter 2 register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_RFC2R_FRAME                      \ frame number


\
\ @brief GFXTIM relative frame counter 2 reload register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000fff constant GFXTIM_S_GFXTIM_RFC2RR_FRAME                     \ frame reload value


\
\ @brief GFXTIM watchdog counter register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000ffff constant GFXTIM_S_GFXTIM_WDGCR_VALUE                      \ value


\
\ @brief GFXTIM watchdog reload register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant GFXTIM_S_GFXTIM_WDGRR_RELOAD                     \ reload value


\
\ @brief GFXTIM watchdog pre-alarm register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000ffff constant GFXTIM_S_GFXTIM_WDGPAR_PREALARM                  \ pre-alarm value


\
\ @brief Graphic timer
\
$58004000 constant GFXTIM_S_GFXTIM_CR  \ offset: 0x00 : GFXTIM configuration register
$58004004 constant GFXTIM_S_GFXTIM_CGCR  \ offset: 0x04 : GFXTIM clock generator configuration register
$58004008 constant GFXTIM_S_GFXTIM_TCR  \ offset: 0x08 : GFXTIM timers configuration register
$5800400c constant GFXTIM_S_GFXTIM_TDR  \ offset: 0x0C : GFXTIM timers disable register
$58004010 constant GFXTIM_S_GFXTIM_EVCR  \ offset: 0x10 : GFXTIM events control register
$58004014 constant GFXTIM_S_GFXTIM_EVSR  \ offset: 0x14 : GFXTIM events selection register
$58004020 constant GFXTIM_S_GFXTIM_WDGTCR  \ offset: 0x20 : GFXTIM watchdog timer configuration register
$58004030 constant GFXTIM_S_GFXTIM_ISR  \ offset: 0x30 : GFXTIM interrupt status register
$58004034 constant GFXTIM_S_GFXTIM_ICR  \ offset: 0x34 : GFXTIM interrupt clear register
$58004038 constant GFXTIM_S_GFXTIM_IER  \ offset: 0x38 : GFXTIM interrupt enable register
$5800403c constant GFXTIM_S_GFXTIM_TSR  \ offset: 0x3C : GFXTIM timers status register
$58004040 constant GFXTIM_S_GFXTIM_LCCRR  \ offset: 0x40 : GFXTIM line clock counter reload register
$58004044 constant GFXTIM_S_GFXTIM_FCCRR  \ offset: 0x44 : GFXTIM frame clock counter reload register
$58004050 constant GFXTIM_S_GFXTIM_ATR  \ offset: 0x50 : GFXTIM absolute time register
$58004054 constant GFXTIM_S_GFXTIM_AFCR  \ offset: 0x54 : GFXTIM absolute frame counter register
$58004058 constant GFXTIM_S_GFXTIM_ALCR  \ offset: 0x58 : GFXTIM absolute line counter register
$58004060 constant GFXTIM_S_GFXTIM_AFCC1R  \ offset: 0x60 : GFXTIM absolute frame counter compare 1 register
$58004070 constant GFXTIM_S_GFXTIM_ALCC1R  \ offset: 0x70 : GFXTIM absolute line counter compare 1 register
$58004074 constant GFXTIM_S_GFXTIM_ALCC2R  \ offset: 0x74 : GFXTIM absolute line counter compare 2 register
$58004080 constant GFXTIM_S_GFXTIM_RFC1R  \ offset: 0x80 : GFXTIM relative frame counter 1 register
$58004084 constant GFXTIM_S_GFXTIM_RFC1RR  \ offset: 0x84 : GFXTIM relative frame counter 1 reload register
$58004088 constant GFXTIM_S_GFXTIM_RFC2R  \ offset: 0x88 : GFXTIM relative frame counter 2 register
$5800408c constant GFXTIM_S_GFXTIM_RFC2RR  \ offset: 0x8C : GFXTIM relative frame counter 2 reload register
$580040a0 constant GFXTIM_S_GFXTIM_WDGCR  \ offset: 0xA0 : GFXTIM watchdog counter register
$580040a4 constant GFXTIM_S_GFXTIM_WDGRR  \ offset: 0xA4 : GFXTIM watchdog reload register
$580040a8 constant GFXTIM_S_GFXTIM_WDGPAR  \ offset: 0xA8 : GFXTIM watchdog pre-alarm register

