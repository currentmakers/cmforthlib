\
\ @file cryp2.fs
\ @brief CRYP2 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CRYP control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant CRYP2_CRYP_CR_ALGODIR                            \ ALGODIR
$00000038 constant CRYP2_CRYP_CR_ALGOMODE                           \ ALGOMODE
$000000c0 constant CRYP2_CRYP_CR_DATATYPE                           \ DATATYPE
$00000300 constant CRYP2_CRYP_CR_KEYSIZE                            \ KEYSIZE
$00004000 constant CRYP2_CRYP_CR_FFLUSH                             \ FFLUSH
$00008000 constant CRYP2_CRYP_CR_CRYPEN                             \ CRYPEN
$00030000 constant CRYP2_CRYP_CR_GCM_CCMPH                          \ GCM_CCMPH
$00080000 constant CRYP2_CRYP_CR_ALGOMODE3                          \ ALGOMODE3
$00f00000 constant CRYP2_CRYP_CR_NPBLB                              \ NPBLB


\
\ @brief CRYP status register
\ Address offset: 0x04
\ Reset value: 0x00000003
\

$00000001 constant CRYP2_CRYP_SR_IFEM                               \ IFEM
$00000002 constant CRYP2_CRYP_SR_IFNF                               \ IFNF
$00000004 constant CRYP2_CRYP_SR_OFNE                               \ OFNE
$00000008 constant CRYP2_CRYP_SR_OFFU                               \ OFFU
$00000010 constant CRYP2_CRYP_SR_BUSY                               \ BUSY


\
\ @brief The CRYP_DIN register is the data input register. It is 32-bit wide. It is used to enter into the input FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DIN register is written to the data are pushed into the input FIFO. If CRYPEN = 1, when at least two 32-bit words in the DES/TDES mode have been pushed into the input FIFO (four words in the AES mode), and when at least two words are free in the output FIFO (four words in the AES mode), the CRYP engine starts an encrypting or decrypting process. When CRYP_DIN register is read: If CRYPEN = 0, the FIFO is popped, and then the data present in the Input FIFO are returned, from the oldest one (first reading) to the newest one (last reading). The IFEM flag must be checked before each read operation to make sure that the FIFO is not empty. if CRYPEN = 1, an undefined value is returned. After the CRYP_DIN register has been read once or several times, the FIFO must be flushed by setting the FFLUSH bit prior to processing new data.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_DIN_DATAIN                            \ DATAIN


\
\ @brief The CRYP_DOUT register is the data output register. It is read-only and 32-bit wide. It is used to retrieve from the output FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DOUT register is read, the last data entered into the output FIFO (pointed to by the read pointer) is returned.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_DOUT_DATAOUT                          \ DATAOUT


\
\ @brief CRYP DMA control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_DMACR_DIEN                            \ DIEN
$00000002 constant CRYP2_CRYP_DMACR_DOEN                            \ DOEN


\
\ @brief The CRYP_IMSCR register is the interrupt mask set or clear register. It is a read/write register. When a read operation is performed, this register gives the current value of the mask applied to the relevant interrupt. Writing 1 to the particular bit sets the mask, thus enabling the interrupt to be read. Writing 0 to this bit clears the corresponding mask. All the bits are cleared to 0 when the peripheral is reset.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_IMSCR_INIM                            \ INIM
$00000002 constant CRYP2_CRYP_IMSCR_OUTIM                           \ OUTIM


\
\ @brief The CRYP_RISR register is the raw interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current raw status of the corresponding interrupt, i.e. the interrupt information without taking CRYP_IMSCR mask into account. Write operations have no effect.
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant CRYP2_CRYP_RISR_INRIS                            \ INRIS
$00000002 constant CRYP2_CRYP_RISR_OUTRIS                           \ OUTRIS


\
\ @brief The CRYP_MISR register is the masked interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current masked status of the corresponding interrupt, i.e. the interrupt information taking CRYP_IMSCR mask into account. Write operations have no effect.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_MISR_INMIS                            \ INMIS
$00000002 constant CRYP2_CRYP_MISR_OUTMIS                           \ OUTMIS


\
\ @brief CRYP key registers contain the cryptographic keys. In DES/TDES mode, the keys are 64-bit binary values (number from left to right, that is the leftmost bit is bit 1) and named K1, K2 and K3 (K0 is not used). Each key consists of 56 information bits and 8 parity bits. In AES mode, the key is considered as a single 128, 192 or 256 bits long sequence K0K1K2...K127/191/255. The AES key is entered into the registers as follows: for AES-128: K0..K127 corresponds to b127..b0 (b255..b128 are not used), for AES-192: K0..K191 corresponds to b191..b0 (b255..b192 are not used), for AES-256: K0..K255 corresponds to b255..b0. In all cases key bit K0 is the leftmost bit in CRYP inner memory and register bit b0 is the rightmost bit in corresponding CRYP_KxLR key register. For more information refer to Section39.3.17: CRYP key registers. Write accesses to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K0LR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K0RR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K1LR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K1RR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K2LR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K2RR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K3LR_K                                \ K


\
\ @brief Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_K3RR_K                                \ K


\
\ @brief The CRYP_IV0...1(L/R)R are the left-word and right-word registers for the initialization vector (64 bits for DES/TDES and 128 bits for AES). For more information refer to Section39.3.18: CRYP initialization vector registers. IV0 is the leftmost bit whereas IV63 (DES, TDES) or IV127 (AES) are the rightmost bits of the initialization vector. IV1(L/R)R is used only in the AES. Only CRYP_IV0(L/R) is used in DES/TDES. Write access to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register).
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_IV0LR_IV31                            \ IV31
$00000002 constant CRYP2_CRYP_IV0LR_IV30                            \ IV30
$00000004 constant CRYP2_CRYP_IV0LR_IV29                            \ IV29
$00000008 constant CRYP2_CRYP_IV0LR_IV28                            \ IV28
$00000010 constant CRYP2_CRYP_IV0LR_IV27                            \ IV27
$00000020 constant CRYP2_CRYP_IV0LR_IV26                            \ IV26
$00000040 constant CRYP2_CRYP_IV0LR_IV25                            \ IV25
$00000080 constant CRYP2_CRYP_IV0LR_IV24                            \ IV24
$00000100 constant CRYP2_CRYP_IV0LR_IV23                            \ IV23
$00000200 constant CRYP2_CRYP_IV0LR_IV22                            \ IV22
$00000400 constant CRYP2_CRYP_IV0LR_IV21                            \ IV21
$00000800 constant CRYP2_CRYP_IV0LR_IV20                            \ IV20
$00001000 constant CRYP2_CRYP_IV0LR_IV19                            \ IV19
$00002000 constant CRYP2_CRYP_IV0LR_IV18                            \ IV18
$00004000 constant CRYP2_CRYP_IV0LR_IV17                            \ IV17
$00008000 constant CRYP2_CRYP_IV0LR_IV16                            \ IV16
$00010000 constant CRYP2_CRYP_IV0LR_IV15                            \ IV15
$00020000 constant CRYP2_CRYP_IV0LR_IV14                            \ IV14
$00040000 constant CRYP2_CRYP_IV0LR_IV13                            \ IV13
$00080000 constant CRYP2_CRYP_IV0LR_IV12                            \ IV12
$00100000 constant CRYP2_CRYP_IV0LR_IV11                            \ IV11
$00200000 constant CRYP2_CRYP_IV0LR_IV10                            \ IV10
$00400000 constant CRYP2_CRYP_IV0LR_IV9                             \ IV9
$00800000 constant CRYP2_CRYP_IV0LR_IV8                             \ IV8
$01000000 constant CRYP2_CRYP_IV0LR_IV7                             \ IV7
$02000000 constant CRYP2_CRYP_IV0LR_IV6                             \ IV6
$04000000 constant CRYP2_CRYP_IV0LR_IV5                             \ IV5
$08000000 constant CRYP2_CRYP_IV0LR_IV4                             \ IV4
$10000000 constant CRYP2_CRYP_IV0LR_IV3                             \ IV3
$20000000 constant CRYP2_CRYP_IV0LR_IV2                             \ IV2
$40000000 constant CRYP2_CRYP_IV0LR_IV1                             \ IV1
$80000000 constant CRYP2_CRYP_IV0LR_IV0                             \ IV0


\
\ @brief Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_IV0RR_IV63                            \ IV63
$00000002 constant CRYP2_CRYP_IV0RR_IV62                            \ IV62
$00000004 constant CRYP2_CRYP_IV0RR_IV61                            \ IV61
$00000008 constant CRYP2_CRYP_IV0RR_IV60                            \ IV60
$00000010 constant CRYP2_CRYP_IV0RR_IV59                            \ IV59
$00000020 constant CRYP2_CRYP_IV0RR_IV58                            \ IV58
$00000040 constant CRYP2_CRYP_IV0RR_IV57                            \ IV57
$00000080 constant CRYP2_CRYP_IV0RR_IV56                            \ IV56
$00000100 constant CRYP2_CRYP_IV0RR_IV55                            \ IV55
$00000200 constant CRYP2_CRYP_IV0RR_IV54                            \ IV54
$00000400 constant CRYP2_CRYP_IV0RR_IV53                            \ IV53
$00000800 constant CRYP2_CRYP_IV0RR_IV52                            \ IV52
$00001000 constant CRYP2_CRYP_IV0RR_IV51                            \ IV51
$00002000 constant CRYP2_CRYP_IV0RR_IV50                            \ IV50
$00004000 constant CRYP2_CRYP_IV0RR_IV49                            \ IV49
$00008000 constant CRYP2_CRYP_IV0RR_IV48                            \ IV48
$00010000 constant CRYP2_CRYP_IV0RR_IV47                            \ IV47
$00020000 constant CRYP2_CRYP_IV0RR_IV46                            \ IV46
$00040000 constant CRYP2_CRYP_IV0RR_IV45                            \ IV45
$00080000 constant CRYP2_CRYP_IV0RR_IV44                            \ IV44
$00100000 constant CRYP2_CRYP_IV0RR_IV43                            \ IV43
$00200000 constant CRYP2_CRYP_IV0RR_IV42                            \ IV42
$00400000 constant CRYP2_CRYP_IV0RR_IV41                            \ IV41
$00800000 constant CRYP2_CRYP_IV0RR_IV40                            \ IV40
$01000000 constant CRYP2_CRYP_IV0RR_IV39                            \ IV39
$02000000 constant CRYP2_CRYP_IV0RR_IV38                            \ IV38
$04000000 constant CRYP2_CRYP_IV0RR_IV37                            \ IV37
$08000000 constant CRYP2_CRYP_IV0RR_IV36                            \ IV36
$10000000 constant CRYP2_CRYP_IV0RR_IV35                            \ IV35
$20000000 constant CRYP2_CRYP_IV0RR_IV34                            \ IV34
$40000000 constant CRYP2_CRYP_IV0RR_IV33                            \ IV33
$80000000 constant CRYP2_CRYP_IV0RR_IV32                            \ IV32


\
\ @brief Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_IV1LR_IV95                            \ IV95
$00000002 constant CRYP2_CRYP_IV1LR_IV94                            \ IV94
$00000004 constant CRYP2_CRYP_IV1LR_IV93                            \ IV93
$00000008 constant CRYP2_CRYP_IV1LR_IV92                            \ IV92
$00000010 constant CRYP2_CRYP_IV1LR_IV91                            \ IV91
$00000020 constant CRYP2_CRYP_IV1LR_IV90                            \ IV90
$00000040 constant CRYP2_CRYP_IV1LR_IV89                            \ IV89
$00000080 constant CRYP2_CRYP_IV1LR_IV88                            \ IV88
$00000100 constant CRYP2_CRYP_IV1LR_IV87                            \ IV87
$00000200 constant CRYP2_CRYP_IV1LR_IV86                            \ IV86
$00000400 constant CRYP2_CRYP_IV1LR_IV85                            \ IV85
$00000800 constant CRYP2_CRYP_IV1LR_IV84                            \ IV84
$00001000 constant CRYP2_CRYP_IV1LR_IV83                            \ IV83
$00002000 constant CRYP2_CRYP_IV1LR_IV82                            \ IV82
$00004000 constant CRYP2_CRYP_IV1LR_IV81                            \ IV81
$00008000 constant CRYP2_CRYP_IV1LR_IV80                            \ IV80
$00010000 constant CRYP2_CRYP_IV1LR_IV79                            \ IV79
$00020000 constant CRYP2_CRYP_IV1LR_IV78                            \ IV78
$00040000 constant CRYP2_CRYP_IV1LR_IV77                            \ IV77
$00080000 constant CRYP2_CRYP_IV1LR_IV76                            \ IV76
$00100000 constant CRYP2_CRYP_IV1LR_IV75                            \ IV75
$00200000 constant CRYP2_CRYP_IV1LR_IV74                            \ IV74
$00400000 constant CRYP2_CRYP_IV1LR_IV73                            \ IV73
$00800000 constant CRYP2_CRYP_IV1LR_IV72                            \ IV72
$01000000 constant CRYP2_CRYP_IV1LR_IV71                            \ IV71
$02000000 constant CRYP2_CRYP_IV1LR_IV70                            \ IV70
$04000000 constant CRYP2_CRYP_IV1LR_IV69                            \ IV69
$08000000 constant CRYP2_CRYP_IV1LR_IV68                            \ IV68
$10000000 constant CRYP2_CRYP_IV1LR_IV67                            \ IV67
$20000000 constant CRYP2_CRYP_IV1LR_IV66                            \ IV66
$40000000 constant CRYP2_CRYP_IV1LR_IV65                            \ IV65
$80000000 constant CRYP2_CRYP_IV1LR_IV64                            \ IV64


\
\ @brief Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant CRYP2_CRYP_IV1RR_IV127                           \ IV127
$00000002 constant CRYP2_CRYP_IV1RR_IV126                           \ IV126
$00000004 constant CRYP2_CRYP_IV1RR_IV125                           \ IV125
$00000008 constant CRYP2_CRYP_IV1RR_IV124                           \ IV124
$00000010 constant CRYP2_CRYP_IV1RR_IV123                           \ IV123
$00000020 constant CRYP2_CRYP_IV1RR_IV122                           \ IV122
$00000040 constant CRYP2_CRYP_IV1RR_IV121                           \ IV121
$00000080 constant CRYP2_CRYP_IV1RR_IV120                           \ IV120
$00000100 constant CRYP2_CRYP_IV1RR_IV119                           \ IV119
$00000200 constant CRYP2_CRYP_IV1RR_IV118                           \ IV118
$00000400 constant CRYP2_CRYP_IV1RR_IV117                           \ IV117
$00000800 constant CRYP2_CRYP_IV1RR_IV116                           \ IV116
$00001000 constant CRYP2_CRYP_IV1RR_IV115                           \ IV115
$00002000 constant CRYP2_CRYP_IV1RR_IV114                           \ IV114
$00004000 constant CRYP2_CRYP_IV1RR_IV113                           \ IV113
$00008000 constant CRYP2_CRYP_IV1RR_IV112                           \ IV112
$00010000 constant CRYP2_CRYP_IV1RR_IV111                           \ IV111
$00020000 constant CRYP2_CRYP_IV1RR_IV110                           \ IV110
$00040000 constant CRYP2_CRYP_IV1RR_IV109                           \ IV109
$00080000 constant CRYP2_CRYP_IV1RR_IV108                           \ IV108
$00100000 constant CRYP2_CRYP_IV1RR_IV107                           \ IV107
$00200000 constant CRYP2_CRYP_IV1RR_IV106                           \ IV106
$00400000 constant CRYP2_CRYP_IV1RR_IV105                           \ IV105
$00800000 constant CRYP2_CRYP_IV1RR_IV104                           \ IV104
$01000000 constant CRYP2_CRYP_IV1RR_IV103                           \ IV103
$02000000 constant CRYP2_CRYP_IV1RR_IV102                           \ IV102
$04000000 constant CRYP2_CRYP_IV1RR_IV101                           \ IV101
$08000000 constant CRYP2_CRYP_IV1RR_IV100                           \ IV100
$10000000 constant CRYP2_CRYP_IV1RR_IV99                            \ IV99
$20000000 constant CRYP2_CRYP_IV1RR_IV98                            \ IV98
$40000000 constant CRYP2_CRYP_IV1RR_IV97                            \ IV97
$80000000 constant CRYP2_CRYP_IV1RR_IV96                            \ IV96


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM0R_CSGCMCCM0                  \ CSGCMCCM0


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM1R_CSGCMCCM1                  \ CSGCMCCM1


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM2R_CSGCMCCM2                  \ CSGCMCCM2


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM3R_CSGCMCCM3                  \ CSGCMCCM3


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM4R_CSGCMCCM4                  \ CSGCMCCM4


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM5R_CSGCMCCM5                  \ CSGCMCCM5


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM6R_CSGCMCCM6                  \ CSGCMCCM6


\
\ @brief These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCMCCM7R_CSGCMCCM7                  \ CSGCMCCM7


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM0R_CSGCM0                        \ CSGCM0


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM1R_CSGCM1                        \ CSGCM1


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM2R_CSGCM2                        \ CSGCM2


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM3R_CSGCM3                        \ CSGCM3


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM4R_CSGCM4                        \ CSGCM4


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM5R_CSGCM5                        \ CSGCM5


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM6R_CSGCM6                        \ CSGCM6


\
\ @brief Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant CRYP2_CRYP_CSGCM7R_CSGCM7                        \ CSGCM7


\
\ @brief CRYP hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000131
\

$0000000f constant CRYP2_CRYP_HWCFGR_CFG1                           \ CFG1
$000000f0 constant CRYP2_CRYP_HWCFGR_CFG2                           \ CFG2
$00000f00 constant CRYP2_CRYP_HWCFGR_CFG3                           \ CFG3
$0000f000 constant CRYP2_CRYP_HWCFGR_CFG4                           \ CFG4


\
\ @brief CRYP HW Version Register
\ Address offset: 0x3F4
\ Reset value: 0x00000022
\

$000000ff constant CRYP2_CRYP_VERR_VER                              \ VER


\
\ @brief CRYP Identification
\ Address offset: 0x3F8
\ Reset value: 0x00170011
\

$00000000 constant CRYP2_CRYP_IPIDR_ID                              \ ID


\
\ @brief CRYP HW Magic ID
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant CRYP2_CRYP_MID_MID                               \ MID


\
\ @brief CRYP2 global interrupt
\
$4c005000 constant CRYP2_CRYP_CR  \ offset: 0x00 : CRYP control register
$4c005004 constant CRYP2_CRYP_SR  \ offset: 0x04 : CRYP status register
$4c005008 constant CRYP2_CRYP_DIN  \ offset: 0x08 : The CRYP_DIN register is the data input register. It is 32-bit wide. It is used to enter into the input FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DIN register is written to the data are pushed into the input FIFO. If CRYPEN = 1, when at least two 32-bit words in the DES/TDES mode have been pushed into the input FIFO (four words in the AES mode), and when at least two words are free in the output FIFO (four words in the AES mode), the CRYP engine starts an encrypting or decrypting process. When CRYP_DIN register is read: If CRYPEN = 0, the FIFO is popped, and then the data present in the Input FIFO are returned, from the oldest one (first reading) to the newest one (last reading). The IFEM flag must be checked before each read operation to make sure that the FIFO is not empty. if CRYPEN = 1, an undefined value is returned. After the CRYP_DIN register has been read once or several times, the FIFO must be flushed by setting the FFLUSH bit prior to processing new data.
$4c00500c constant CRYP2_CRYP_DOUT  \ offset: 0x0C : The CRYP_DOUT register is the data output register. It is read-only and 32-bit wide. It is used to retrieve from the output FIFO up to four 64-bit blocks (TDES) or two 128-bit blocks (AES) of plaintext (when encrypting) or ciphertext (when decrypting), one 32-bit word at a time. To fit different data sizes, the data can be swapped after processing by configuring the DATATYPE bits in the CRYP_CR register. Refer to Section39.3.16: CRYP data registers and data swapping for more details. When CRYP_DOUT register is read, the last data entered into the output FIFO (pointed to by the read pointer) is returned.
$4c005010 constant CRYP2_CRYP_DMACR  \ offset: 0x10 : CRYP DMA control register
$4c005014 constant CRYP2_CRYP_IMSCR  \ offset: 0x14 : The CRYP_IMSCR register is the interrupt mask set or clear register. It is a read/write register. When a read operation is performed, this register gives the current value of the mask applied to the relevant interrupt. Writing 1 to the particular bit sets the mask, thus enabling the interrupt to be read. Writing 0 to this bit clears the corresponding mask. All the bits are cleared to 0 when the peripheral is reset.
$4c005018 constant CRYP2_CRYP_RISR  \ offset: 0x18 : The CRYP_RISR register is the raw interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current raw status of the corresponding interrupt, i.e. the interrupt information without taking CRYP_IMSCR mask into account. Write operations have no effect.
$4c00501c constant CRYP2_CRYP_MISR  \ offset: 0x1C : The CRYP_MISR register is the masked interrupt status register. It is a read-only register. When a read operation is performed, this register gives the current masked status of the corresponding interrupt, i.e. the interrupt information taking CRYP_IMSCR mask into account. Write operations have no effect.
$4c005020 constant CRYP2_CRYP_K0LR  \ offset: 0x20 : CRYP key registers contain the cryptographic keys. In DES/TDES mode, the keys are 64-bit binary values (number from left to right, that is the leftmost bit is bit 1) and named K1, K2 and K3 (K0 is not used). Each key consists of 56 information bits and 8 parity bits. In AES mode, the key is considered as a single 128, 192 or 256 bits long sequence K0K1K2...K127/191/255. The AES key is entered into the registers as follows: for AES-128: K0..K127 corresponds to b127..b0 (b255..b128 are not used), for AES-192: K0..K191 corresponds to b191..b0 (b255..b192 are not used), for AES-256: K0..K255 corresponds to b255..b0. In all cases key bit K0 is the leftmost bit in CRYP inner memory and register bit b0 is the rightmost bit in corresponding CRYP_KxLR key register. For more information refer to Section39.3.17: CRYP key registers. Write accesses to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register)
$4c005024 constant CRYP2_CRYP_K0RR  \ offset: 0x24 : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c005028 constant CRYP2_CRYP_K1LR  \ offset: 0x28 : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c00502c constant CRYP2_CRYP_K1RR  \ offset: 0x2C : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c005030 constant CRYP2_CRYP_K2LR  \ offset: 0x30 : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c005034 constant CRYP2_CRYP_K2RR  \ offset: 0x34 : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c005038 constant CRYP2_CRYP_K3LR  \ offset: 0x38 : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c00503c constant CRYP2_CRYP_K3RR  \ offset: 0x3C : Refer to Section39.6.9: CRYP key register 0L (CRYP_K0LR) for details.
$4c005040 constant CRYP2_CRYP_IV0LR  \ offset: 0x40 : The CRYP_IV0...1(L/R)R are the left-word and right-word registers for the initialization vector (64 bits for DES/TDES and 128 bits for AES). For more information refer to Section39.3.18: CRYP initialization vector registers. IV0 is the leftmost bit whereas IV63 (DES, TDES) or IV127 (AES) are the rightmost bits of the initialization vector. IV1(L/R)R is used only in the AES. Only CRYP_IV0(L/R) is used in DES/TDES. Write access to these registers are disregarded when the cryptographic processor is busy (bit BUSY = 1 in the CRYP_SR register).
$4c005044 constant CRYP2_CRYP_IV0RR  \ offset: 0x44 : Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
$4c005048 constant CRYP2_CRYP_IV1LR  \ offset: 0x48 : Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
$4c00504c constant CRYP2_CRYP_IV1RR  \ offset: 0x4C : Refer to Section39.6.17: CRYP initialization vector register 0L (CRYP_IV0LR) for details.
$4c005050 constant CRYP2_CRYP_CSGCMCCM0R  \ offset: 0x50 : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c005054 constant CRYP2_CRYP_CSGCMCCM1R  \ offset: 0x54 : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c005058 constant CRYP2_CRYP_CSGCMCCM2R  \ offset: 0x58 : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c00505c constant CRYP2_CRYP_CSGCMCCM3R  \ offset: 0x5C : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c005060 constant CRYP2_CRYP_CSGCMCCM4R  \ offset: 0x60 : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c005064 constant CRYP2_CRYP_CSGCMCCM5R  \ offset: 0x64 : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c005068 constant CRYP2_CRYP_CSGCMCCM6R  \ offset: 0x68 : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c00506c constant CRYP2_CRYP_CSGCMCCM7R  \ offset: 0x6C : These registers contain the complete internal register states of the CRYP processor when the GCM/GMAC or CCM algorithm is selected. They are useful when a context swap has to be performed because a high-priority task needs the cryptographic processor while it is already in use by another task. When such an event occurs, the CRYP_CSGCMCCM0..7R and CRYP_CSGCM0..7R (in GCM/GMAC mode) or CRYP_CSGCMCCM0..7R (in CCM mode) registers have to be read and the values retrieved have to be saved in the system memory space. The cryptographic processor can then be used by the preemptive task. Then when the cryptographic computation is complete, the saved context can be read from memory and written back into the corresponding context swap registers.
$4c005070 constant CRYP2_CRYP_CSGCM0R  \ offset: 0x70 : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c005074 constant CRYP2_CRYP_CSGCM1R  \ offset: 0x74 : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c005078 constant CRYP2_CRYP_CSGCM2R  \ offset: 0x78 : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c00507c constant CRYP2_CRYP_CSGCM3R  \ offset: 0x7C : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c005080 constant CRYP2_CRYP_CSGCM4R  \ offset: 0x80 : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c005084 constant CRYP2_CRYP_CSGCM5R  \ offset: 0x84 : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c005088 constant CRYP2_CRYP_CSGCM6R  \ offset: 0x88 : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c00508c constant CRYP2_CRYP_CSGCM7R  \ offset: 0x8C : Please refer to Section39.6.21: CRYP context swap GCM-CCM registers (CRYP_CSGCMCCMxR) for details.
$4c0053f0 constant CRYP2_CRYP_HWCFGR  \ offset: 0x3F0 : CRYP hardware configuration register
$4c0053f4 constant CRYP2_CRYP_VERR  \ offset: 0x3F4 : CRYP HW Version Register
$4c0053f8 constant CRYP2_CRYP_IPIDR  \ offset: 0x3F8 : CRYP Identification
$4c0053fc constant CRYP2_CRYP_MID  \ offset: 0x3FC : CRYP HW Magic ID

