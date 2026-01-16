\
\ @file usbphyc.fs
\ @brief USBPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief This register is used to control the PLL of the HS PHY.
\ Address offset: 0x00
\ Reset value: 0xC0000000
\

$0000007f constant USBPHYC_USBPHYC_PLL_PLLNDIV                      \ PLLNDIV
$00000380 constant USBPHYC_USBPHYC_PLL_PLLODF                       \ PLLODF
$03fffc00 constant USBPHYC_USBPHYC_PLL_PLLFRACIN                    \ PLLFRACIN
$04000000 constant USBPHYC_USBPHYC_PLL_PLLEN                        \ PLLEN
$08000000 constant USBPHYC_USBPHYC_PLL_PLLSTRB                      \ PLLSTRB
$10000000 constant USBPHYC_USBPHYC_PLL_PLLSTRBYP                    \ PLLSTRBYP
$20000000 constant USBPHYC_USBPHYC_PLL_PLLFRACCTL                   \ PLLFRACCTL
$40000000 constant USBPHYC_USBPHYC_PLL_PLLDITHEN0                   \ PLLDITHEN0
$80000000 constant USBPHYC_USBPHYC_PLL_PLLDITHEN1                   \ PLLDITHEN1


\
\ @brief This register is used to control the switch between controllers for the HS PHY.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant USBPHYC_USBPHYC_MISC_SWITHOST                    \ SWITHOST
$00000006 constant USBPHYC_USBPHYC_MISC_PPCKDIS                     \ PPCKDIS


\
\ @brief This register is used to control the tune interface of the HS PHY, port #x.
\ Address offset: 0x10C
\ Reset value: 0x04070004
\

$00000001 constant USBPHYC_USBPHYC_TUNE1_INCURREN                   \ INCURREN
$00000002 constant USBPHYC_USBPHYC_TUNE1_INCURRINT                  \ INCURRINT
$00000004 constant USBPHYC_USBPHYC_TUNE1_LFSCAPEN                   \ LFSCAPEN
$00000008 constant USBPHYC_USBPHYC_TUNE1_HSDRVSLEW                  \ HSDRVSLEW
$00000010 constant USBPHYC_USBPHYC_TUNE1_HSDRVDCCUR                 \ HSDRVDCCUR
$00000020 constant USBPHYC_USBPHYC_TUNE1_HSDRVDCLEV                 \ HSDRVDCLEV
$00000040 constant USBPHYC_USBPHYC_TUNE1_HSDRVCURINCR               \ HSDRVCURINCR
$00000080 constant USBPHYC_USBPHYC_TUNE1_FSDRVRFADJ                 \ FSDRVRFADJ
$00000100 constant USBPHYC_USBPHYC_TUNE1_HSDRVRFRED                 \ HSDRVRFRED
$00001e00 constant USBPHYC_USBPHYC_TUNE1_HSDRVCHKITRM               \ HSDRVCHKITRM
$00006000 constant USBPHYC_USBPHYC_TUNE1_HSDRVCHKZTRM               \ HSDRVCHKZTRM
$000f8000 constant USBPHYC_USBPHYC_TUNE1_OTPCOMP                    \ OTPCOMP
$00300000 constant USBPHYC_USBPHYC_TUNE1_SQLCHCTL                   \ SQLCHCTL
$00400000 constant USBPHYC_USBPHYC_TUNE1_HDRXGNEQEN                 \ HDRXGNEQEN
$01800000 constant USBPHYC_USBPHYC_TUNE1_HSRXOFF                    \ HSRXOFF
$02000000 constant USBPHYC_USBPHYC_TUNE1_HSFALLPREEM                \ HSFALLPREEM
$04000000 constant USBPHYC_USBPHYC_TUNE1_SHTCCTCTLPROT              \ SHTCCTCTLPROT
$08000000 constant USBPHYC_USBPHYC_TUNE1_STAGSEL                    \ STAGSEL


\
\ @brief This register is used to control the tune interface of the HS PHY, port #x.
\ Address offset: 0x20C
\ Reset value: 0x04070004
\

$00000001 constant USBPHYC_USBPHYC_TUNE2_INCURREN                   \ INCURREN
$00000002 constant USBPHYC_USBPHYC_TUNE2_INCURRINT                  \ INCURRINT
$00000004 constant USBPHYC_USBPHYC_TUNE2_LFSCAPEN                   \ LFSCAPEN
$00000008 constant USBPHYC_USBPHYC_TUNE2_HSDRVSLEW                  \ HSDRVSLEW
$00000010 constant USBPHYC_USBPHYC_TUNE2_HSDRVDCCUR                 \ HSDRVDCCUR
$00000020 constant USBPHYC_USBPHYC_TUNE2_HSDRVDCLEV                 \ HSDRVDCLEV
$00000040 constant USBPHYC_USBPHYC_TUNE2_HSDRVCURINCR               \ HSDRVCURINCR
$00000080 constant USBPHYC_USBPHYC_TUNE2_FSDRVRFADJ                 \ FSDRVRFADJ
$00000100 constant USBPHYC_USBPHYC_TUNE2_HSDRVRFRED                 \ HSDRVRFRED
$00001e00 constant USBPHYC_USBPHYC_TUNE2_HSDRVCHKITRM               \ HSDRVCHKITRM
$00006000 constant USBPHYC_USBPHYC_TUNE2_HSDRVCHKZTRM               \ HSDRVCHKZTRM
$000f8000 constant USBPHYC_USBPHYC_TUNE2_OTPCOMP                    \ OTPCOMP
$00300000 constant USBPHYC_USBPHYC_TUNE2_SQLCHCTL                   \ SQLCHCTL
$00400000 constant USBPHYC_USBPHYC_TUNE2_HDRXGNEQEN                 \ HDRXGNEQEN
$01800000 constant USBPHYC_USBPHYC_TUNE2_HSRXOFF                    \ HSRXOFF
$02000000 constant USBPHYC_USBPHYC_TUNE2_HSFALLPREEM                \ HSFALLPREEM
$04000000 constant USBPHYC_USBPHYC_TUNE2_SHTCCTCTLPROT              \ SHTCCTCTLPROT
$08000000 constant USBPHYC_USBPHYC_TUNE2_STAGSEL                    \ STAGSEL


\
\ @brief This register defines the version of this IP.
\ Address offset: 0xFFC
\ Reset value: 0x00000010
\

$0000000f constant USBPHYC_USBPHYC_VERR_MINREV                      \ MINREV
$000000f0 constant USBPHYC_USBPHYC_VERR_MAJREV                      \ MAJREV


\
\ @brief USBPHYC
\
$5a006000 constant USBPHYC_USBPHYC_PLL  \ offset: 0x00 : This register is used to control the PLL of the HS PHY.
$5a006008 constant USBPHYC_USBPHYC_MISC  \ offset: 0x08 : This register is used to control the switch between controllers for the HS PHY.
$5a00610c constant USBPHYC_USBPHYC_TUNE1  \ offset: 0x10C : This register is used to control the tune interface of the HS PHY, port #x.
$5a00620c constant USBPHYC_USBPHYC_TUNE2  \ offset: 0x20C : This register is used to control the tune interface of the HS PHY, port #x.
$5a006ffc constant USBPHYC_USBPHYC_VERR  \ offset: 0xFFC : This register defines the version of this IP.

